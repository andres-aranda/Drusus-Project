using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Business.Entities
{
    public class Venta : BusinessEntity
    {
        public Venta()
        {

        }
        private string _Descripcion;
        private int _Monto;
        private int _idCliente;
        private DateTime _Fecha;

        protected SqlDataAdapter _daVentas;

        public SqlDataAdapter daVentas
        {
            get { return _daVentas; }
            set { _daVentas = value; }
        }

        protected SqlConnection _conn;

        public SqlConnection Conn
        {
            get { return _conn; }
            set { _conn = value; }
        }

        public DataTable GetAll()
        {
            DataTable dtVentas = new DataTable();
            this.daVentas.Fill(dtVentas);
            return dtVentas;
        }
        public void GuardarCambios(DataTable dtVentas)
        {
            this.daVentas.Update(dtVentas);
            dtVentas.AcceptChanges();
        }
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        public int Monto
        {
            get { return _Monto; }
            set { _Monto = value; }
        }
        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
    }
}
