namespace Sistema_Seguradora_PIM
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Entrar_Tela_Inicial_Cliente = new System.Windows.Forms.Button();
            this.Btn_Entrar_Tela_Inicial_Colaborador = new System.Windows.Forms.Button();
            this.Titulo_SGAP_Tela_Principal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Entrar_Tela_Inicial_Cliente
            // 
            this.Btn_Entrar_Tela_Inicial_Cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Entrar_Tela_Inicial_Cliente.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Entrar_Tela_Inicial_Cliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Entrar_Tela_Inicial_Cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Entrar_Tela_Inicial_Cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Entrar_Tela_Inicial_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Entrar_Tela_Inicial_Cliente.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Entrar_Tela_Inicial_Cliente.ForeColor = System.Drawing.Color.White;
            this.Btn_Entrar_Tela_Inicial_Cliente.Location = new System.Drawing.Point(267, 283);
            this.Btn_Entrar_Tela_Inicial_Cliente.Name = "Btn_Entrar_Tela_Inicial_Cliente";
            this.Btn_Entrar_Tela_Inicial_Cliente.Size = new System.Drawing.Size(122, 37);
            this.Btn_Entrar_Tela_Inicial_Cliente.TabIndex = 5;
            this.Btn_Entrar_Tela_Inicial_Cliente.Text = "Segurado";
            this.Btn_Entrar_Tela_Inicial_Cliente.UseVisualStyleBackColor = false;
            this.Btn_Entrar_Tela_Inicial_Cliente.Click += new System.EventHandler(this.Btn_Entrar_Tela_Inicial_Cliente_Click);
            // 
            // Btn_Entrar_Tela_Inicial_Colaborador
            // 
            this.Btn_Entrar_Tela_Inicial_Colaborador.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Entrar_Tela_Inicial_Colaborador.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Entrar_Tela_Inicial_Colaborador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Entrar_Tela_Inicial_Colaborador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Entrar_Tela_Inicial_Colaborador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Entrar_Tela_Inicial_Colaborador.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Entrar_Tela_Inicial_Colaborador.ForeColor = System.Drawing.Color.White;
            this.Btn_Entrar_Tela_Inicial_Colaborador.Location = new System.Drawing.Point(407, 283);
            this.Btn_Entrar_Tela_Inicial_Colaborador.Name = "Btn_Entrar_Tela_Inicial_Colaborador";
            this.Btn_Entrar_Tela_Inicial_Colaborador.Size = new System.Drawing.Size(138, 37);
            this.Btn_Entrar_Tela_Inicial_Colaborador.TabIndex = 6;
            this.Btn_Entrar_Tela_Inicial_Colaborador.Text = "Colaborador";
            this.Btn_Entrar_Tela_Inicial_Colaborador.UseVisualStyleBackColor = false;
            // 
            // Titulo_SGAP_Tela_Principal
            // 
            this.Titulo_SGAP_Tela_Principal.AutoSize = true;
            this.Titulo_SGAP_Tela_Principal.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_SGAP_Tela_Principal.ForeColor = System.Drawing.Color.White;
            this.Titulo_SGAP_Tela_Principal.Location = new System.Drawing.Point(335, 133);
            this.Titulo_SGAP_Tela_Principal.Name = "Titulo_SGAP_Tela_Principal";
            this.Titulo_SGAP_Tela_Principal.Size = new System.Drawing.Size(140, 48);
            this.Titulo_SGAP_Tela_Principal.TabIndex = 7;
            this.Titulo_SGAP_Tela_Principal.Text = "SGAP";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Titulo_SGAP_Tela_Principal);
            this.panel1.Controls.Add(this.Btn_Entrar_Tela_Inicial_Colaborador);
            this.panel1.Controls.Add(this.Btn_Entrar_Tela_Inicial_Cliente);
            this.panel1.Location = new System.Drawing.Point(-8, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 463);
            this.panel1.TabIndex = 2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Entrar_Tela_Inicial_Cliente;
        private System.Windows.Forms.Button Btn_Entrar_Tela_Inicial_Colaborador;
        private System.Windows.Forms.Label Titulo_SGAP_Tela_Principal;
        private System.Windows.Forms.Panel panel1;
    }
}