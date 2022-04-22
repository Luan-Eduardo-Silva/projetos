namespace Sistema_Seguradora_PIM
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.Button Home_Btn_Login_Segurado;
            System.Windows.Forms.Button Home_Btn_Login_Colaborador;
            this.Home_SGAP_Sigla = new System.Windows.Forms.Label();
            this.Home_Nome_SGAP = new System.Windows.Forms.Label();
            this.Home_Subtitulo_Login = new System.Windows.Forms.Label();
            this.Home_Texto_Logar_Como = new System.Windows.Forms.Label();
            this.Home_fundo_login = new System.Windows.Forms.Panel();
            Home_Btn_Login_Segurado = new System.Windows.Forms.Button();
            Home_Btn_Login_Colaborador = new System.Windows.Forms.Button();
            this.Home_fundo_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // Home_SGAP_Sigla
            // 
            resources.ApplyResources(this.Home_SGAP_Sigla, "Home_SGAP_Sigla");
            this.Home_SGAP_Sigla.ForeColor = System.Drawing.Color.White;
            this.Home_SGAP_Sigla.Name = "Home_SGAP_Sigla";
            this.Home_SGAP_Sigla.Click += new System.EventHandler(this.SGAP_Sigla_Click);
            // 
            // Home_Nome_SGAP
            // 
            resources.ApplyResources(this.Home_Nome_SGAP, "Home_Nome_SGAP");
            this.Home_Nome_SGAP.ForeColor = System.Drawing.Color.White;
            this.Home_Nome_SGAP.Name = "Home_Nome_SGAP";
            // 
            // Home_Subtitulo_Login
            // 
            resources.ApplyResources(this.Home_Subtitulo_Login, "Home_Subtitulo_Login");
            this.Home_Subtitulo_Login.ForeColor = System.Drawing.Color.White;
            this.Home_Subtitulo_Login.Name = "Home_Subtitulo_Login";
            // 
            // Home_Texto_Logar_Como
            // 
            resources.ApplyResources(this.Home_Texto_Logar_Como, "Home_Texto_Logar_Como");
            this.Home_Texto_Logar_Como.ForeColor = System.Drawing.Color.White;
            this.Home_Texto_Logar_Como.Name = "Home_Texto_Logar_Como";
            this.Home_Texto_Logar_Como.Click += new System.EventHandler(this.label3_Click);
            // 
            // Home_Btn_Login_Segurado
            // 
            resources.ApplyResources(Home_Btn_Login_Segurado, "Home_Btn_Login_Segurado");
            Home_Btn_Login_Segurado.BackColor = System.Drawing.Color.Transparent;
            Home_Btn_Login_Segurado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            Home_Btn_Login_Segurado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            Home_Btn_Login_Segurado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            Home_Btn_Login_Segurado.ForeColor = System.Drawing.Color.White;
            Home_Btn_Login_Segurado.Name = "Home_Btn_Login_Segurado";
            Home_Btn_Login_Segurado.UseVisualStyleBackColor = false;
            // 
            // Home_Btn_Login_Colaborador
            // 
            Home_Btn_Login_Colaborador.AllowDrop = true;
            resources.ApplyResources(Home_Btn_Login_Colaborador, "Home_Btn_Login_Colaborador");
            Home_Btn_Login_Colaborador.AutoEllipsis = true;
            Home_Btn_Login_Colaborador.BackColor = System.Drawing.Color.Transparent;
            Home_Btn_Login_Colaborador.FlatAppearance.BorderColor = System.Drawing.Color.White;
            Home_Btn_Login_Colaborador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            Home_Btn_Login_Colaborador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            Home_Btn_Login_Colaborador.ForeColor = System.Drawing.Color.White;
            Home_Btn_Login_Colaborador.Name = "Home_Btn_Login_Colaborador";
            Home_Btn_Login_Colaborador.UseCompatibleTextRendering = true;
            Home_Btn_Login_Colaborador.UseVisualStyleBackColor = true;
            Home_Btn_Login_Colaborador.UseWaitCursor = true;
            Home_Btn_Login_Colaborador.Click += new System.EventHandler(this.Btn_Login_Colaborador_Click);
            // 
            // Home_fundo_login
            // 
            resources.ApplyResources(this.Home_fundo_login, "Home_fundo_login");
            this.Home_fundo_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.Home_fundo_login.Controls.Add(Home_Btn_Login_Colaborador);
            this.Home_fundo_login.Controls.Add(Home_Btn_Login_Segurado);
            this.Home_fundo_login.Controls.Add(this.Home_Texto_Logar_Como);
            this.Home_fundo_login.Controls.Add(this.Home_Subtitulo_Login);
            this.Home_fundo_login.Controls.Add(this.Home_Nome_SGAP);
            this.Home_fundo_login.Controls.Add(this.Home_SGAP_Sigla);
            this.Home_fundo_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.Home_fundo_login.Name = "Home_fundo_login";
            this.Home_fundo_login.Paint += new System.Windows.Forms.PaintEventHandler(this.Fundo_login_Paint);
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Home_fundo_login);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Home_fundo_login.ResumeLayout(false);
            this.Home_fundo_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Home_SGAP_Sigla;
        private System.Windows.Forms.Label Home_Nome_SGAP;
        private System.Windows.Forms.Label Home_Subtitulo_Login;
        private System.Windows.Forms.Label Home_Texto_Logar_Como;
        private System.Windows.Forms.Panel Home_fundo_login;
    }
}

