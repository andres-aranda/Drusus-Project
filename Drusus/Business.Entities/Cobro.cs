using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Business.Entities
{
    public class Cobro : BusinessEntity
    {
        public Cobro()
        {

        }
        private string _Descripcion;
        private int _Monto;
        private int _idCliente;
        private DateTime _Fecha;

        protected SqlDataAdapter _daCobros;

        public SqlDataAdapter daCobros
        {
            get { return _daCobros; }
            set { _daCobros = value; }
        }

        protected SqlConnection _conn;

        public SqlConnection Conn
        {
            get { return _conn; }
            set { _conn = value; }
        }

        public DataTable GetAll()
        {
            DataTable dtCobros = new DataTable();
            this.daCobros.Fill(dtCobros);
            return dtCobros;
        }
        public void GuardarCambios(DataTable dtCobros)
        {
            this.daCobros.Update(dtCobros);
            dtCobros.AcceptChanges();
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
        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
    }
}
