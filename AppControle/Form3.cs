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

namespace AppCadastro
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            GetAllClientes();
        }

        private void BtnAtualizar_Click_1(object sender, EventArgs e)
        {
            GetAllClientes();
        }
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
                        dataGridView1.DataSource = JsonConvert.DeserializeObject<Clientes[]>(ClientesJsonString).ToList();
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
