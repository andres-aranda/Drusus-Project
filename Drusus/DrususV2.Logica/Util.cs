using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public static class Util
    {
        private class DolarResponse
        {
            [JsonPropertyName("venta")]
            public double Venta { get; set; }
        }

        public static async Task<double> DolarAPI()
        {
            double valorDolar = 0;
            string url = "https://dolarapi.com/v1/dolares/blue";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetFromJsonAsync<DolarResponse>(url);
                    if (response != null)
                    {
                        valorDolar = response.Venta;
                    }
                }
                catch
                {
                    // Fallback
                }
            }
            return valorDolar;
        }

        public static List<Cliente> ObtenerListaClientes()
        {
            using (drususEntities db = new drususEntities())
            {
                return db.Clientes
                    .Where(c => (c.direccion != "Este cliente fue eliminado" && c.direccion != "Este cliente es deudor") || c.direccion == null)
                    .OrderBy(c => c.apellido)
                    .ToList();
            }
        }

        public static List<Cliente> ObtenerListaTodosLosClientes()
        {
            using (drususEntities db = new drususEntities())
            {
                return db.Clientes.OrderBy(c => c.apellido).ToList();
            }
        }

        public static async Task<List<Cliente>> ObtenerListaClientesAsync()
        {
            using (drususEntities db = new drususEntities())
            {
                return await db.Clientes
                    .Where(c => (c.direccion != "Este cliente fue eliminado" && c.direccion != "Este cliente es deudor") || c.direccion == null)
                    .OrderBy(c => c.apellido)
                    .ToListAsync();
            }
        }

        public static async Task<List<Cliente>> ObtenerListaTodosLosClientesAsync()
        {
            using (drususEntities db = new drususEntities())
            {
                return await db.Clientes.OrderBy(c => c.apellido).ToListAsync();
            }
        }

        public static void MensajeError()
        {
            MessageBox.Show("Ha ocurrido un error intentelo mas tarde. ");
        }

        public static List<Cliente> ActualizarDeudas()
        {
            try
            {
                using (drususEntities db = new drususEntities())
                {
                    foreach (var cliente in db.Clientes)
                    {
                        // Corrido de fechas
                        cliente.masVentiunDias = (cliente.masVentiunDias ?? 0) + (cliente.veintiunDias ?? 0);
                        cliente.veintiunDias = cliente.catorceDias ?? 0;
                        cliente.catorceDias = cliente.sieteDias ?? 0;
                        cliente.sieteDias = 0;

                        // Registro cambio
                        db.Entry(cliente).State = EntityState.Modified;
                    }
                    // Persiste en base
                    db.SaveChanges();
                    return db.Clientes.ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error al actualizar las deudas intentelo mas tarde " + e.Message);
                return new List<Cliente>();
            }
        }
    }
}
