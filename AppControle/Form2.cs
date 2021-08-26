using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCadastro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            AtualizarDataHora();
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

    }
}
