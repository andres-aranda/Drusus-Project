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
    public class CobroAdapter : Adapter
    {
        public void Insert(Cobro m)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO Cobro (descripcion, fecha, monto, idCobro)" +
                    " VALUES (@descripcion, @fecha, @monto, @idCobro)" +
                    " SELECT @@identity", Sqlconn);

                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = m.Descripcion;
                cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = m.Fecha;
                cmd.Parameters.Add("@monto", SqlDbType.Int).Value = m.Monto;
                cmd.Parameters.Add("@idCobro", SqlDbType.Int).Value = m.Id;
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

        public void Save(Cobro m)
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

        public void Update(Cobro cobro)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("UPDATE Cobro SET descripcion = @descripcion, fecha = @fecha," +
                    " monto = @monto, idCobro = @idCobro" +
                    " WHERE idCobro = @id", Sqlconn);
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = cobro.Descripcion;
                cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = cobro.Fecha;
                cmd.Parameters.Add("@monto", SqlDbType.Int).Value = cobro.Monto;
                cmd.Parameters.Add("@idCobro", SqlDbType.Int).Value = cobro.Id;
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
        public List<Cobro> GetCobrosCliente(int idCliente)
        {
            List<Cobro> cobros = new List<Cobro>();
            try
            {
                OpenConnection();
                SqlCommand cmdCobros = new SqlCommand("SELECT * FROM Cobro  WHERE idCliente = @idCliente", Sqlconn);
                cmdCobros.Parameters.Add("@idCliente", SqlDbType.Int).Value = idCliente;
                SqlDataReader drCobros = cmdCobros.ExecuteReader();
                while (drCobros.Read())
                {
                    Cobro m = new Cobro();

                    m.Descripcion = (string)drCobros["descripcion"];
                    m.Fecha = (DateTime)drCobros["fecha"];
                    m.Monto = (int)drCobros["monto"];
                    m.Id = (int)drCobros["idCobro"];
                    m.IdCliente = (int)drCobros["idCliente"];

                    cobros.Add(m);
                }
                drCobros.Close();
            }
            catch (Exception e)
            {
                Exception ex = new Exception("Error al recuperar la lista de cobros", e);
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return cobros;
        }
        public int GetMontoDeClientePorFechaC(int id, DateTime desde, DateTime hasta)
        {
            int monto = 0;
            try
            {

                OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT  SUM(monto) as 'monto' FROM Cobro where idCliente= @id and fecha between @hasta and @desde", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@desde", SqlDbType.DateTime).Value = desde;
                cmd.Parameters.Add("@hasta", SqlDbType.DateTime).Value = hasta;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() && (!(dr["monto"] == DBNull.Value)))
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
        public int GetMontoDeClientePorFechaCMax(int id, DateTime desde)
        {
            int monto = 0;
            try
            {

                OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT  SUM(monto) as 'monto' FROM Cobro where idCliente= @id and fecha <= @desde", Sqlconn);
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

        public Cobro GetOne(int id)
        {
            Cobro cobro = new Cobro();
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Cobro WHERE idCobro = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cobro.Descripcion = (string)dr["descripcion"];
                    cobro.Fecha = (DateTime)dr["fecha"];
                    cobro.Monto = (int)dr["monto"];
                    cobro.Id = (int)dr["idCobro"];
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
            return cobro;
        }

        public List<Cobro> GetAll()
        {
            List<Cobro> cobros = new List<Cobro>();
            try
            {
                OpenConnection();
                SqlCommand cmdCobros = new SqlCommand("SELECT * FROM Cobro", Sqlconn);
                SqlDataReader drCobros = cmdCobros.ExecuteReader();
                while (drCobros.Read())
                {
                    Cobro m = new Cobro();

                    m.Descripcion = (string)drCobros["descripcion"];
                    m.Fecha = (DateTime)drCobros["fecha"];
                    m.Monto = (int)drCobros["monto"];
                    m.Id = (int)drCobros["idCobro"];

                    cobros.Add(m);
                }
                drCobros.Close();
            }
            catch (Exception e)
            {
                Exception ex = new Exception("Error al recuperar la lista de cobros", e);
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return cobros;
        }

        public void Delete(int id)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("DELETE Cobro WHERE idCobro = @id", Sqlconn);
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
