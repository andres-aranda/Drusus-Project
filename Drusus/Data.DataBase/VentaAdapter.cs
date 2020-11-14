using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Data.Database
{
    public class VentaAdapter : Adapter
    {
        public void Insert(Venta m)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO Venta (descripcion, fecha, monto,idCliente)" +
                    " VALUES (@descripcion, @fecha, @monto,@idCliente) SELECT @@identity", Sqlconn);

                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = m.Descripcion;
                cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = m.Fecha;
                cmd.Parameters.Add("@monto", SqlDbType.Int).Value = m.Monto;
                cmd.Parameters.Add("@idCliente", SqlDbType.Int).Value = m.IdCliente;
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

        public void Save(Venta m)
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

        public void Update(Venta venta)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("UPDATE Venta SET descripcion = @descripcion, fecha = @fecha," +
                    " monto = @monto, idCliente = @idCliente" +
                    " WHERE idVenta = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = venta.Id;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = venta.Descripcion;
                cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = venta.Fecha;
                cmd.Parameters.Add("@monto", SqlDbType.Int).Value = venta.Monto;
                cmd.Parameters.Add("@idCliente", SqlDbType.Int).Value = venta.IdCliente;
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

        public Venta GetOne(int id)
        {
            Venta venta = new Venta();
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Venta WHERE idVenta = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    venta.Id = (int)dr["idVenta"];
                    venta.Descripcion = (string)dr["descripcion"];
                    venta.Fecha = (DateTime)dr["fecha"];
                    venta.Monto = (int)dr["monto"];
                    venta.IdCliente = (int)dr["idCliente"];
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
            return venta;
        }
        public int GetMontoDeClientePorFechaV(int id, DateTime desde, DateTime hasta)
        {
            int monto = 0;
            try
            {

                OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT  SUM(monto) as 'monto' FROM Venta where idCliente= @id and fecha between @hasta and @desde", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@desde", SqlDbType.DateTime).Value = desde;
                cmd.Parameters.Add("@hasta", SqlDbType.DateTime).Value = hasta;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (!(dr["monto"]==DBNull.Value))
                    {
                    monto = (int)dr["monto"]   ;
                    }
                    
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
            return monto;
        }
        public int GetMontoDeClientePorFechaVMax(int id, DateTime desde)
        {
            int monto=0;
            try
            {

                OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT  SUM(monto) as 'monto' FROM Venta where idCliente= @id and fecha <= @desde", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@desde", SqlDbType.DateTime).Value = desde;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read()&& (!(dr["monto"] == DBNull.Value)))
                {
                    monto = (int)dr["monto"];
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
            return monto;
        }

        public List<Venta> GetVentasCliente(int idCliente)
        {
            List<Venta> ventas = new List<Venta>();
            try
            {
                OpenConnection();
                SqlCommand cmdVentas = new SqlCommand("SELECT * FROM Venta  WHERE idCliente = @idCliente", Sqlconn);
                cmdVentas.Parameters.Add("@idCliente", SqlDbType.Int).Value = idCliente;
                SqlDataReader drVentas = cmdVentas.ExecuteReader();
                while (drVentas.Read())
                {
                    Venta m = new Venta();

                    m.Descripcion = (string)drVentas["descripcion"];
                    m.Fecha = (DateTime)drVentas["fecha"];
                    m.Monto = (int)drVentas["monto"];
                    m.Id = (int)drVentas["idVenta"];
                    m.IdCliente = (int)drVentas["idCliente"];

                    ventas.Add(m);
                }
                drVentas.Close();
            }
            catch (Exception e)
            {
                Exception ex = new Exception("Error al recuperar la lista de ventas", e);
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return ventas;
        }
         public List<Venta> GetAll()
        {
            List<Venta> ventas = new List<Venta>();
            try
            {
                OpenConnection();
                SqlCommand cmdVentas = new SqlCommand("SELECT * FROM Venta", Sqlconn);
                SqlDataReader drVentas = cmdVentas.ExecuteReader();
                while (drVentas.Read())
                {
                    Venta m = new Venta();

                    m.Descripcion = (string)drVentas["descripcion"];
                    m.Fecha = (DateTime)drVentas["fecha"];
                    m.Monto = (int)drVentas["monto"];
                    m.Id = (int)drVentas["idVenta"];
                    m.IdCliente = (int)drVentas["idCliente"];

                    ventas.Add(m);
                }
                drVentas.Close();
            }
            catch (Exception e)
            {
                Exception ex = new Exception("Error al recuperar la lista de ventas", e);
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return ventas;
        }

        public void Delete(int id)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("DELETE Venta WHERE idVenta = @id", Sqlconn);
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
