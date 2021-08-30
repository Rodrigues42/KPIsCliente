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
    public partial class Noticias : Form
    {
        public Noticias()
        {
            InitializeComponent();
            TransparencyKey = Color.FromArgb(30, 30, 30);
            BackColor = Color.FromArgb(30, 30, 30);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Noticias_Load(object sender, EventArgs e)
        {
            TransparencyKey = Color.FromArgb(30, 30, 30);
            BackColor = Color.FromArgb(30, 30, 30);
        }
    }
}
