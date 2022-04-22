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
    public partial class Home : Form
    {

        Thread Nova_Janela;

        public Home()
        {         
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Fundo_login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SGAP_Sigla_Click(object sender, EventArgs e)
        {

        }


        private void AbrirJanela( object obj)
        {
            Application.Run(new Login_Colaborador());
        }

        private void Btn_Login_Colaborador_Click(object sender, EventArgs e)
        {
            this.Close();
            Nova_Janela = new Thread(AbrirJanela);
            Nova_Janela.SetApartmentState(ApartmentState.STA);
            Nova_Janela.Start();
        }

    }
}


