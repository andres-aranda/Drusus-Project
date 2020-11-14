using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class GastoLogic : BusinessLogic
    {
        public GastoAdapter GastoData { get; set; }

        public GastoLogic()
        {
            GastoData = new GastoAdapter();
        }

        public List<Gasto> GetAll()
        {
            return GastoData.GetAll();
        }

        public Gasto GetOne(int id)
        {
            return GastoData.GetOne(id);
        }

        public void Save(Gasto m)
        {
            GastoData.Save(m);
        }

        public void Delete(int id)
        {
            GastoData.Delete(id);
        }
    }
}
