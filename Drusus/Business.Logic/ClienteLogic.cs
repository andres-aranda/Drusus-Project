using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class ClienteLogic : BusinessLogic
    {
        public ClienteAdapter ClienteData { get; set; }

        public ClienteLogic()
        {
            ClienteData = new ClienteAdapter();
        }

        public List<Cliente> GetAll()
        {
            return ClienteData.GetAll();
        }

        public Cliente GetOne(int id)
        {
            return ClienteData.GetOne(id);
        }
    
        public void Save(Cliente m)
        {
            ClienteData.Save(m);
        }

        public void Delete(int id)
        {
            ClienteData.Delete(id);
        }
    }
}
