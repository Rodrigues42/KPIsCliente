using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Http;

namespace AppCadastro
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(30, 30, 30);
            ForeColor = Color.FromArgb(0, 0, 0);
            TransparencyKey = Color.Black;

            this.panel4.Controls.Clear();
            Dashboard telaDashboard = new Dashboard() { Dock = DockStyle.Right, TopLevel = false, TopMost = true };
            telaDashboard.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(telaDashboard);
            telaDashboard.Show();

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(30, 30, 30);
            BtnClientes.BackColor = Color.FromArgb(5, 5, 100);
            BtnCalendario.BackColor = Color.FromArgb(5, 5, 100);
            BtnNoticias.BackColor = Color.FromArgb(5, 5, 100);
            BtnConfigura.BackColor = Color.FromArgb(5, 5, 100);

            LbnDescricao.Text = BtnDashboard.Text;

            this.panel4.Controls.Clear();
            Dashboard telaDashboard = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            telaDashboard.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(telaDashboard);
            telaDashboard.Show();

        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
 
            BtnDashboard.BackColor = Color.FromArgb(5, 5, 100);
            BtnClientes.BackColor = Color.FromArgb(30, 30, 30);
            BtnCalendario.BackColor = Color.FromArgb(5, 5, 100);
            BtnNoticias.BackColor = Color.FromArgb(5, 5, 100);
            BtnConfigura.BackColor = Color.FromArgb(5, 5, 100);

            LbnDescricao.Text = BtnClientes.Text;

            this.panel4.Controls.Clear();
            DbClientes tabela = new DbClientes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            tabela.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(tabela);
            tabela.Show();

        }
        private void Calendario_Click_1(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(5, 5, 100);
            BtnClientes.BackColor = Color.FromArgb(5, 5, 100);
            BtnCalendario.BackColor = Color.FromArgb(30, 30, 30);
            BtnNoticias.BackColor = Color.FromArgb(5, 5, 100);
            BtnConfigura.BackColor = Color.FromArgb(5, 5, 100);

            LbnDescricao.Text = BtnCalendario.Text;

            this.panel4.Controls.Clear();
            Calendario tabela = new Calendario() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            tabela.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(tabela);
            tabela.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            BtnDashboard.BackColor = Color.FromArgb(5, 5, 100);
            BtnClientes.BackColor = Color.FromArgb(5, 5, 100);
            BtnCalendario.BackColor = Color.FromArgb(5, 5, 100);
            BtnNoticias.BackColor = Color.FromArgb(30, 30, 30);
            BtnConfigura.BackColor = Color.FromArgb(5, 5, 100);

            LbnDescricao.Text = BtnNoticias.Text;

            this.panel4.Controls.Clear();
            Noticias tabela = new Noticias() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            tabela.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(tabela);
            tabela.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            BtnDashboard.BackColor = Color.FromArgb(5, 5, 100);
            BtnClientes.BackColor = Color.FromArgb(5, 5, 100);
            BtnCalendario.BackColor = Color.FromArgb(5, 5, 100);
            BtnNoticias.BackColor = Color.FromArgb(5, 5, 100);
            BtnConfigura.BackColor = Color.FromArgb(30, 30, 30);

            LbnDescricao.Text = BtnConfigura.Text;

            this.panel4.Controls.Clear();
            Configurar telaDashboard = new Configurar() { Dock = DockStyle.Right, TopLevel = false, TopMost = true };
            telaDashboard.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(telaDashboard);
            telaDashboard.Show();

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
