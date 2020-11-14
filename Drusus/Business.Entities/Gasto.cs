using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Business.Entities
{
    public class Gasto:BusinessEntity
    {
        public Gasto()
        {

        }
        private string _Descripcion;
        private int _idCliente;
        private int _Costo;
        private DateTime _Fecha;

        protected SqlDataAdapter _daGastos;

        public SqlDataAdapter daGastos
        {
            get { return _daGastos; }
            set { _daGastos = value; }
        }

        protected SqlConnection _conn;

        public SqlConnection Conn
        {
            get { return _conn; }
            set { _conn = value; }
        }

        public DataTable GetAll()
        {
            DataTable dtGastos = new DataTable();
            this.daGastos.Fill(dtGastos);
            return dtGastos;
        }
        public void GuardarCambios(DataTable dtGastos)
        {
            this.daGastos.Update(dtGastos);
            dtGastos.AcceptChanges();
        }
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        public int idCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
        public int Costo
        {
            get { return _Costo; }
            set { _Costo = value; }
        }
        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
    }
}
