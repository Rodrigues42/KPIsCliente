using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppCadastro
{
    public partial class DbClientes : Form
    {
        public static List<Clientes> Dados { get; set; }
        public static int valorTotal { get; set; }

        public DbClientes()
        {
            InitializeComponent();
            GetAllClientes();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            GetAllClientes();
        }

        private void BtnAtualizar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Buscando informações ...");
            
            GetAllClientes();
        }
        public async void GetAllClientes()
        {
            try
            {
                var URI = "http://localhost:5000/clientes";

                using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync(URI))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var ClientesJsonString = await response.Content.ReadAsStringAsync();
                            Dados = JsonConvert.DeserializeObject<Clientes[]>(ClientesJsonString).ToList();
                            dataGridView1.DataSource = JsonConvert.DeserializeObject<Clientes[]>(ClientesJsonString).ToList();
                            }
                        else
                        {
                            MessageBox.Show("Não Foi possível obter os clientes: " + response.StatusCode);
                        }
                    }
                }
                int soma = 0;
                foreach (var clientes in Dados)
                {
                    soma += clientes.valorTotal;
                }
                valorTotal = soma;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao se conectar na API");
            }
        }
    }
}
