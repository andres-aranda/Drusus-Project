using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Data.Database
{
    public class ClienteAdapter : Adapter
    {
        public CobroAdapter CobroData { get; private set; }
        public VentaAdapter VentaData { get; private set; }

        public void Insert(Cliente m)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO Cliente (nombre, apellido, cuil, direccion)" +
                    " VALUES (@nombre, @apellido, @cuil,@direccion)" +
                    " SELECT @@identity", Sqlconn);

                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = m.Nombre;
                cmd.Parameters.Add("@apellido", SqlDbType.Int).Value = m.Apellido;
                cmd.Parameters.Add("@direccion", SqlDbType.Int).Value = m.Direccion;
                cmd.Parameters.Add("@cuil", SqlDbType.Int).Value = m.CUIL;
                m.Id = decimal.ToInt32((decimal)cmd.ExecuteScalar());
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Save(Cliente m)
        {
            if (m.State == BusinessEntity.Estados.New)
            {
                this.Insert(m);
            }
            else if (m.State == BusinessEntity.Estados.Deleted)
            {
                this.Delete(m.Id);
            }
            else if (m.State == BusinessEntity.Estados.Modified)
            {
                this.Update(m);
            }
            m.State = BusinessEntity.Estados.Unmodified;
        }

        public void Update(Cliente cliente)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("UPDATE Cliente SET nombre = @nombre, apellido = @apellido," +
                    " cuil = @cuil, direccion=@direccion " +
                    " WHERE idCliente = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = cliente.Id;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = cliente.Nombre;
                cmd.Parameters.Add("@apellido", SqlDbType.Int).Value = cliente.Apellido;
                cmd.Parameters.Add("@direccion", SqlDbType.Int).Value = cliente.Direccion;
                cmd.Parameters.Add("@cuil", SqlDbType.Int).Value = cliente.CUIL;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CloseConnection();
            }
        }

        public Cliente GetOne(int id)
        {
            Cliente cliente = new Cliente();
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente WHERE idCliente = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    VentaData = new VentaAdapter();
                    List<Venta> ventas = VentaData.GetVentasCliente((int)dr["idCliente"]);
                    CobroData = new CobroAdapter();
                    List<Cobro> cobros = CobroData.GetAll();
                    int aux = 0;
                    foreach (Venta v in ventas)
                    {
                        aux -= v.Monto;
                    }
                    foreach (Cobro c in cobros)
                    {
                        aux += c.Monto;
                    }
                    cliente.Pagos = cobros;
                    cliente.Compras = ventas;
                    cliente.Id = (int)dr["idCliente"];
                    cliente.Nombre = (string)dr["nombre"];
                    cliente.Direccion = (string)dr["direccion"];
                    cliente.Apellido = (string)dr["apellido"];
                    cliente.CUIL = (int)dr["cuil"];
                    cliente.Deuda = aux;
                }
                dr.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CloseConnection();
            }
            return cliente;
        }

        public List<Cliente> GetAll()
        {
            DateTime Hoy = DateTime.Today;
            List<Cliente> clientes = new List<Cliente>();
            CobroData = new CobroAdapter();
            List<Cobro> cobros = CobroData.GetAll();
            VentaData = new VentaAdapter();
            List<Venta> ventas = VentaData.GetAll();
            try
            {
                OpenConnection();
                SqlCommand cmdClientes = new SqlCommand("SELECT * FROM Cliente", Sqlconn);
                SqlDataReader drClientes = cmdClientes.ExecuteReader();
                while (drClientes.Read())
                {
                    Cliente m = new Cliente();
                
                   
                    m.Nombre = (string)drClientes["nombre"];
                    m.Apellido = (string)drClientes["apellido"];
                    m.Direccion = (string)drClientes["direccion"];
                    m.CUIL = (int)drClientes["cuil"];
                    m.Id = (int)drClientes["idCliente"];
                  
                    m.Quince = (VentaData.GetMontoDeClientePorFechaV(m.Id, Hoy, Hoy.AddDays(-15))-CobroData.GetMontoDeClientePorFechaC(m.Id,Hoy,Hoy.AddDays(-15)));
                    m.Treinta = (VentaData.GetMontoDeClientePorFechaV(m.Id, Hoy.AddDays(-16), Hoy.AddDays(-31))-CobroData.GetMontoDeClientePorFechaC(m.Id, Hoy.AddDays(-16), Hoy.AddDays(-31)));
                    m.MasTreinta = (VentaData.GetMontoDeClientePorFechaVMax(m.Id, Hoy.AddDays(-32))-CobroData.GetMontoDeClientePorFechaCMax(m.Id, Hoy.AddDays(-32)));
                    m.Deuda = (VentaData.GetMontoDeClientePorFechaVMax(m.Id, Hoy)-CobroData.GetMontoDeClientePorFechaCMax(m.Id, Hoy));
                   
                    m.Compras = ventas.FindAll(
                        delegate (Venta v)
                        {
                            return v.IdCliente == (int)drClientes["idCliente"];
                        });
                    m.Pagos = cobros.FindAll(
                        delegate (Cobro c)
                        {
                            return c.IdCliente == (int)drClientes["idCliente"];
                        });

                    clientes.Add(m);

                }
                drClientes.Close();
            }
            catch (Exception e)
            {
                Exception ex = new Exception("Error al recuperar la lista de clientes", e);
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return clientes;
        }

        public void Delete(int id)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("DELETE Cliente WHERE id_cliente = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
