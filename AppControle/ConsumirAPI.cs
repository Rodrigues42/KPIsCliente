using Newtonsoft.Json.Linq;
using Ninject.Activation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace AppCadastro
{
    public class ConsumirAPI
    {
        public static List<Clientes> dados { get; set; }
        public async void GetAllClientes()
        {
            var URI = "http://localhost:5000/clientes";

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ClientesJsonString = await response.Content.ReadAsStringAsync();
                        dados = JsonConvert.DeserializeObject<Clientes[]>(ClientesJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não Foi possível obter os clientes: " + response.StatusCode);
                    }
                }
            }
        }
    }
}
