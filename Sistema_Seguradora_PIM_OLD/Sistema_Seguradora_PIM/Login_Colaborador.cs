using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Sistema_Seguradora_PIM
{
    public partial class Login_Colaborador : Form 
    {
        public Login_Colaborador()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Colaborador_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Voltar_Home(object obj)
        {
            Application.Run(new Tela_Login());
        }

        private void Btn_Login_Colaborador_Voltar_Home_Click(object sender, EventArgs e)
        {
            this.Close();
            Nova_Janela = new Thread(Voltar_Home);
            Nova_Janela.SetApartmentState(ApartmentState.STA);
            Nova_Janela.Start();
        }

    }
}
