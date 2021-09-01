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
using System.Windows.Forms.DataVisualization.Charting;

namespace AppCadastro
{
    public partial class Dashboard : Form
    {
        public int Meta = 10000;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            AtualizarDataHora();
            ValoresMeta();

            //Barra de progresso
            progressBar1.PerformStep();

            //Números do dashboard
            LbMeta.Text = Meta.ToString("C");
            label3.Text = DbClientes.valorTotal.ToString("C");
            label6.Text = DbClientes.MaiorVenda.ToString("C");
            try
            {
                LbTicketMedio.Text = (DbClientes.valorTotal / DbClientes.QtdClientes).ToString("C");
            } catch (Exception)
            {
                Console.WriteLine("Sem dados");
            }
            try
            {
                label11.Text = DbClientes.Produtos.Count().ToString();
                label9.Text = DbClientes.Estados.Count().ToString();
            } catch (Exception)
            {
                Console.WriteLine("Sem dados");
            }

            label12.Text = DbClientes.QtdClientes.ToString();
        }

        public void AtualizarDataHora()
        {
            label2.Text = DateTime.Now.ToString("dd/MM/yy HH:mm:ss");
            label2.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AtualizarDataHora();
        }

        public void ValoresMeta()
        {
            progressBar1.Maximum = Meta;
            progressBar1.Minimum = 0;
            try
            {
                progressBar1.Value = DbClientes.valorTotal;
            }
            catch (Exception)
            {
                progressBar1.Value = Meta;
            }

            progressBar1.BackColor = Color.FromArgb(30, 30, 30);
        }

        public void GraficoBarras()
        {
        }
    }
}
