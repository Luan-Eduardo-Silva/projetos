using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Seguradora_PIM.Telas_Cliente;
using System.Threading;

namespace Sistema_Seguradora_PIM
{
    public partial class Principal : Form
    {

        Thread Tela;

        public Principal()
        {
            InitializeComponent();
        }

        private void Abrir_Login_Cliente(object obj)
        {
            Application.Run(new Telas_Cliente.Login_Cliente());
        }

        private void Abrir_Tela_Login_Cliente()
        {
            Application.Run(new Telas_Cliente.Login_Cliente());
        }

        private void Btn_Entrar_Tela_Inicial_Cliente_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela = new Thread(Abrir_Tela_Login_Cliente);
            Tela.SetApartmentState(ApartmentState.STA);
            Tela.Start();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
