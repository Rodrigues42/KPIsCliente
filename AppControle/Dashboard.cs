﻿using Newtonsoft.Json;
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
            progressBar1.PerformStep();
            LbMeta.Text = "R$ " + Meta;
            label3.Text = "R$ " + DbClientes.valorTotal;
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
            progressBar1.Value = DbClientes.valorTotal;
            progressBar1.BackColor = Color.FromArgb(30, 30, 30);
        }

        public void GraficoBarras()
        {
        }

    }
}