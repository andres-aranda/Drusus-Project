using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class CobroLogic : BusinessLogic
    {
        public CobroAdapter CobroData { get; set; }

        public CobroLogic()
        {
            CobroData = new CobroAdapter();
        }

        public List<Cobro> GetAll()
        {
            return CobroData.GetAll();
        }

        public Cobro GetOne(int id)
        {
            return CobroData.GetOne(id);
        }

        public void Save(Cobro m)
        {
            CobroData.Save(m);
        }
        public List<Cobro> GetVentasCliente(int idC)
        {
            return CobroData.GetCobrosCliente(idC);
        }
        public void Delete(int id)
        {
            CobroData.Delete(id);
        }
    }
}
