using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class VentaLogic : BusinessLogic
    {
        public VentaAdapter VentaData { get; set; }

        public VentaLogic()
        {
            VentaData = new VentaAdapter();
        }

        public List<Venta> GetAll()
        {
            return VentaData.GetAll();
        }

        public List<Venta> GetVentasCliente(int idC)
        {
            return VentaData.GetVentasCliente(idC);
        }

        public Venta GetOne(int id)
        {
            return VentaData.GetOne(id);
        }

        public void Save(Venta m)
        {
            VentaData.Save(m);
        }
           public void Create(Venta m)
        {
            VentaData.Insert(m);
        }

        public void Delete(int id)
        {
            VentaData.Delete(id);
        }
        
    }
}
