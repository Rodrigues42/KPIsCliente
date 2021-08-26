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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(30, 30, 30);
            ForeColor = Color.FromArgb(0, 0, 0);

            this.panel4.Controls.Clear();
            Form2 telaDashboard = new Form2() { Dock = DockStyle.Right, TopLevel = false, TopMost = true };
            telaDashboard.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(telaDashboard);
            telaDashboard.Show();

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(30, 30, 30);
            BtnClientes.BackColor = Color.FromArgb(5, 5, 100);
            button2.BackColor = Color.FromArgb(5, 5, 100);
            button3.BackColor = Color.FromArgb(5, 5, 100);
            button4.BackColor = Color.FromArgb(5, 5, 100);

            LbnDescricao.Text = BtnDashboard.Text;

            this.panel4.Controls.Clear();
            Form2 telaDashboard = new Form2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            telaDashboard.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(telaDashboard);
            telaDashboard.Show();

        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
 
            BtnDashboard.BackColor = Color.FromArgb(5, 5, 100);
            BtnClientes.BackColor = Color.FromArgb(30, 30, 30);
            button2.BackColor = Color.FromArgb(5, 5, 100);
            button3.BackColor = Color.FromArgb(5, 5, 100);
            button4.BackColor = Color.FromArgb(5, 5, 100);

            LbnDescricao.Text = BtnClientes.Text;

            this.panel4.Controls.Clear();
            Form3 tabela = new Form3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            tabela.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(tabela);
            tabela.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            BtnDashboard.BackColor = Color.FromArgb(5, 5, 100);
            BtnClientes.BackColor = Color.FromArgb(5, 5, 100);
            button2.BackColor = Color.FromArgb(30, 30, 30);
            button3.BackColor = Color.FromArgb(5, 5, 100);
            button4.BackColor = Color.FromArgb(5, 5, 100);

            LbnDescricao.Text = button2.Text;

                   }

        private void button3_Click(object sender, EventArgs e)
        {

            BtnDashboard.BackColor = Color.FromArgb(5, 5, 100);
            BtnClientes.BackColor = Color.FromArgb(5, 5, 100);
            button2.BackColor = Color.FromArgb(5, 5, 100);
            button3.BackColor = Color.FromArgb(30, 30, 30);
            button4.BackColor = Color.FromArgb(5, 5, 100);

            LbnDescricao.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            BtnDashboard.BackColor = Color.FromArgb(5, 5, 100);
            BtnClientes.BackColor = Color.FromArgb(5, 5, 100);
            button2.BackColor = Color.FromArgb(5, 5, 100);
            button3.BackColor = Color.FromArgb(5, 5, 100);
            button4.BackColor = Color.FromArgb(30, 30, 30);

            LbnDescricao.Text = button4.Text;

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
