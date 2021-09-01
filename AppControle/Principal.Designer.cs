
namespace AppCadastro
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnSair = new System.Windows.Forms.Button();
            this.LbnDescricao = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnConfigura = new System.Windows.Forms.Button();
            this.BtnNoticias = new System.Windows.Forms.Button();
            this.BtnCalendario = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.BtnConfigura);
            this.panel1.Controls.Add(this.BtnNoticias);
            this.panel1.Controls.Add(this.BtnCalendario);
            this.panel1.Controls.Add(this.BtnClientes);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 600);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 178);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(0, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // BtnSair
            // 
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.Location = new System.Drawing.Point(864, 0);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(36, 32);
            this.BtnSair.TabIndex = 2;
            this.BtnSair.Text = "X";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LbnDescricao
            // 
            this.LbnDescricao.AutoSize = true;
            this.LbnDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbnDescricao.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LbnDescricao.Location = new System.Drawing.Point(193, 5);
            this.LbnDescricao.Name = "LbnDescricao";
            this.LbnDescricao.Size = new System.Drawing.Size(156, 31);
            this.LbnDescricao.TabIndex = 1;
            this.LbnDescricao.Text = "Dashboard";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(190, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(710, 561);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // BtnConfigura
            // 
            this.BtnConfigura.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnConfigura.FlatAppearance.BorderSize = 0;
            this.BtnConfigura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfigura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfigura.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnConfigura.Image = global::AppCadastro.Properties.Resources.configuration__1_;
            this.BtnConfigura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfigura.Location = new System.Drawing.Point(0, 550);
            this.BtnConfigura.Name = "BtnConfigura";
            this.BtnConfigura.Size = new System.Drawing.Size(190, 50);
            this.BtnConfigura.TabIndex = 5;
            this.BtnConfigura.Text = "Configurações";
            this.BtnConfigura.UseVisualStyleBackColor = true;
            this.BtnConfigura.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnNoticias
            // 
            this.BtnNoticias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.BtnNoticias.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnNoticias.FlatAppearance.BorderSize = 0;
            this.BtnNoticias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNoticias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNoticias.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnNoticias.Image = global::AppCadastro.Properties.Resources.noticias_falsas__1_;
            this.BtnNoticias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNoticias.Location = new System.Drawing.Point(0, 328);
            this.BtnNoticias.Name = "BtnNoticias";
            this.BtnNoticias.Size = new System.Drawing.Size(190, 50);
            this.BtnNoticias.TabIndex = 4;
            this.BtnNoticias.Text = "Noticias";
            this.BtnNoticias.UseVisualStyleBackColor = false;
            this.BtnNoticias.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnCalendario
            // 
            this.BtnCalendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.BtnCalendario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCalendario.FlatAppearance.BorderSize = 0;
            this.BtnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalendario.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCalendario.Image = global::AppCadastro.Properties.Resources.calendario__2_;
            this.BtnCalendario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCalendario.Location = new System.Drawing.Point(0, 278);
            this.BtnCalendario.Name = "BtnCalendario";
            this.BtnCalendario.Size = new System.Drawing.Size(190, 50);
            this.BtnCalendario.TabIndex = 3;
            this.BtnCalendario.Text = "Calendário";
            this.BtnCalendario.UseVisualStyleBackColor = false;
            this.BtnCalendario.Click += new System.EventHandler(this.Calendario_Click_1);
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.BtnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnClientes.Image = global::AppCadastro.Properties.Resources.cliente__1_;
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(0, 228);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(190, 50);
            this.BtnClientes.TabIndex = 2;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = false;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(100)))));
            this.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnDashboard.Image = global::AppCadastro.Properties.Resources.speedometer__1_;
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.Location = new System.Drawing.Point(0, 178);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(190, 50);
            this.BtnDashboard.TabIndex = 1;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::AppCadastro.Properties.Resources.homem_de_negocios;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LbnDescricao);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConfigura;
        private System.Windows.Forms.Button BtnNoticias;
        private System.Windows.Forms.Button BtnCalendario;
        private System.Windows.Forms.Button BtnClientes;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LbnDescricao;
        public System.Windows.Forms.Panel panel4;
    }
}

