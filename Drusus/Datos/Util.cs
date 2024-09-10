using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    static public class Util
    {

        private static double Promise(WebResponse response)
        {
            using (Stream strReader = response.GetResponseStream())
            {
                double auxUSS = 0;
                if (strReader == null) return 0;
                using (StreamReader objReader = new StreamReader(strReader))
                {
                    string responseBody = objReader.ReadToEnd();

                    dynamic ObjOrderList = JsonConvert.DeserializeObject<dynamic>(responseBody);
                    foreach (var item in ObjOrderList)
                    {
                        switch ((string)item.casa.nombre)
                        {
                            case "Dolar Blue":
                                {
                                    string aux = (string)item.casa.venta;
                                    //auxUSS = double.Parse(aux.Replace(',', '.'));
                                   auxUSS = double.Parse(aux.Substring(0, 3));
                               
                              
                                }
                                break;
                            default:
                                break;
                        }


                    }
                    return auxUSS;

                }
            }
        }
        public static async Task<double> DolarAPI()
        {
            double valorDolar = 0;
			
            string url = "https://dolarapi.com/v1/dolares/blue";

			using (HttpClient client = new HttpClient())
			{
				try
				{
					HttpResponseMessage response = await client.GetAsync(url);
					response.EnsureSuccessStatusCode();

					string responseBody = await response.Content.ReadAsStringAsync();

					// Deserializar el JSON y obtener el valor de "venta"
					JObject jsonResponse = JObject.Parse(responseBody);
					 valorDolar = jsonResponse["venta"].Value<double>();

					return valorDolar;
				}
				catch (HttpRequestException e)
				{
                    return valorDolar;
				}
			}

		}
        public static List<Cliente> ObtenerListaClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            using (drususEntities db = new drususEntities())
            {
                clientes = db.Database.SqlQuery<Cliente>("SELECT * from Cliente where direccion <> 'Este cliente fue eliminado' and direccion <> 'Este cliente es deudor' or direccion is null order by apellido").ToList();

            }
            return clientes;
        }
        public static List<Cliente> ObtenerListaTodosLosClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            using (drususEntities db = new drususEntities())
            {
                clientes = db.Database.SqlQuery<Cliente>("SELECT * from Cliente order by apellido").ToList();

            }
            return clientes;
        }
        public static void MensajeError()
        {
            MessageBox.Show("Ha ocurrido un error intentelo mas tarde");
        }
        public static List<Cliente> ActualizarDeudas()
        {

            try
            {
                using (drususEntities db = new drususEntities())
                {
                    foreach (var cliente in db.Clientes)
                    {
                        //Corrido de fechas
                        cliente.masVentiunDias += cliente.veintiunDias;
                        cliente.veintiunDias = cliente.catorceDias;
                        cliente.catorceDias = cliente.sieteDias;
                        cliente.sieteDias = 0;
                        //Registro cambio
                        db.Entry(cliente).State = EntityState.Modified;
                    }
                    //Persiste en base
                    db.SaveChanges();
                    return db.Clientes.ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error al actualizar las deudas intentelo mas tarde " + e.Message);

                List<Cliente> vacia = new List<Cliente>();

                return vacia;
            }
        }

        
    }
}
