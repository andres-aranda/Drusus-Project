using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Business.Entities
{
    public class Cliente :BusinessEntity
    {
        public Cliente()
        {

        }
        private string _Nombre;
        private string _Apellido;
        private string _Direccion;
        private int _CUIL;
        private int _Deuda;
        private int _Quince;
        private int _Treinta;
        private int _MasTreinta;
        private int _MontoCompras;
        private int _MontoPagos;
        private List<Venta> _Compras;
        private List<Cobro> _Pagos;

      
        protected SqlDataAdapter _daClientes;

        public SqlDataAdapter daClientes
        {
            get { return _daClientes; }
            set { _daClientes = value; }
        }

        protected SqlConnection _conn;

        public SqlConnection Conn
        {
            get { return _conn; }
            set { _conn = value; }
        }

        public DataTable GetAll()
        {
            DataTable dtClientes = new DataTable();
            this.daClientes.Fill(dtClientes);
            return dtClientes;
        }
        public void GuardarCambios(DataTable dtClientes)
        {
            this.daClientes.Update(dtClientes);
            dtClientes.AcceptChanges();
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
       public int MontoCompras
        {
            get { return _MontoCompras; }
            set { _MontoCompras = value; }
        }
       public int MontoPagos
        {
            get { return _MontoPagos; }
            set { _MontoPagos = value; }
        }
     
        public int CUIL
        {
            get { return _CUIL; }
            set { _CUIL = value; }
        }
        public int Deuda
        {
            get { return _Deuda; }
            set { _Deuda = value; }
        }
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }
             public string ApellidoYNombre
        {
            get { return _Apellido+" "+_Nombre; }
            set { }
        }

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
        public List<Cobro> Pagos
        {
            get { return _Pagos; }
            set { _Pagos = value; }
        }
        public List<Venta> Compras
        {
            get { return _Compras; }
            set { _Compras = value; }
        }
        public int Quince
        {
            get { return _Quince; }
            set { _Quince = value; }
        }
        public int Treinta
        {
            get { return _Treinta; }
            set { _Treinta = value; }
        }  public int MasTreinta
        {
            get { return _MasTreinta; }
            set { _MasTreinta = value; }
        }

    }
}
