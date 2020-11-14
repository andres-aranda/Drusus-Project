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
    public class GastoAdapter: Adapter
    {
        public void Insert(Gasto m)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO Gasto (descripcion, fecha, costo, idGasto)" +
                    " VALUES (@descripcion, @fecha, @costo, @idGasto)" +
                    " SELECT @@identity", Sqlconn);

                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = m.Descripcion;
                cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = m.Fecha;
                cmd.Parameters.Add("@costo", SqlDbType.Int).Value = m.Costo;
                cmd.Parameters.Add("@idGasto", SqlDbType.Int).Value = m.Id;
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

        public void Save(Gasto m)
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

        public void Update(Gasto gasto)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("UPDATE Gasto SET descripcion = @descripcion, fecha = @fecha," +
                    " costo = @costo, idGasto = @idGasto" +
                    " WHERE idGasto = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = gasto.Id;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = gasto.Descripcion;
                cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = gasto.Fecha;
                cmd.Parameters.Add("@costo", SqlDbType.Int).Value = gasto.Costo;
                cmd.Parameters.Add("@idGasto", SqlDbType.Int).Value = gasto.Id;
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

        public Gasto GetOne(int id)
        {
            Gasto gasto = new Gasto();
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Gasto WHERE idGasto = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    gasto.Id = (int)dr["idGasto"];
                    gasto.Descripcion = (string)dr["descripcion"];
                    gasto.Fecha = (DateTime)dr["fecha"];
                    gasto.Costo = (int)dr["costo"];
                    gasto.Id = (int)dr["idGasto"];
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
            return gasto;
        }

        public List<Gasto> GetAll()
        {
            List<Gasto> gastos = new List<Gasto>();
            try
            {
                OpenConnection();
                SqlCommand cmdGastos = new SqlCommand("SELECT * FROM Gasto", Sqlconn);
                SqlDataReader drGastos = cmdGastos.ExecuteReader();
                while (drGastos.Read())
                {
                    Gasto m = new Gasto();
              
                    m.Descripcion = (string)drGastos["descripcion"];
                    m.Fecha = (DateTime)drGastos["fecha"];
                    m.Costo = (int)drGastos["costo"];
                    m.Id = (int)drGastos["idGasto"];
                   
                    gastos.Add(m);
                }
                drGastos.Close();
            }
            catch (Exception e)
            {
                Exception ex = new Exception("Error al recuperar la lista de gastos", e);
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return gastos;
        }

        public void Delete(int id)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("DELETE Gasto WHERE idGasto = @id", Sqlconn);
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
