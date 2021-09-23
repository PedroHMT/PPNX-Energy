using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class roteador : Form
    {
        public roteador()
        {
            InitializeComponent();
        }

        private void PanelChart_Paint(object sender, PaintEventArgs e)
        {

        }

        roteadorCl R = new roteadorCl();
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                R._potenciaR = txt_r1.Text;
                R._frequencia = int.Parse(txt_f.Text);
                R._corrente = int.Parse(txt_c.Text);
                R._qtdR = int.Parse(cmb_r1.Text);
                R.inserir();
            }
            finally
            {
                MessageBox.Show("Informações cadastradas com sucesso!!!");
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                R._potenciaR = txt_r1.Text;
                R._frequencia = int.Parse(txt_f.Text);
                R._corrente = int.Parse(txt_c.Text);
                R._qtdR = int.Parse(cmb_r1.Text);
                R._equipamento_codigoR = int.Parse(txt_cod.Text);
                R.editar();
            }
            finally
            {
                MessageBox.Show("Informações alteradas com sucesso!!!");
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {

                R._equipamento_codigoR = int.Parse(txt_cod.Text);
                R.editar();
            }
            finally
            {
                MessageBox.Show("Informações excluida com sucesso!!!");
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Inicial form = new Inicial();
            form.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Cadastro_de_Equipamentos form = new Cadastro_de_Equipamentos();
            form.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            painelControle form = new painelControle();
            form.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            usuarioX form = new usuarioX();
            form.Show();
        }
    }
}
