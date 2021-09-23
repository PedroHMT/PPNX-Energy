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
    public partial class maquina_lavar : Form
    {
        public maquina_lavar()
        {
            InitializeComponent();
        }

        maquinalCl ML = new maquinalCl();
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                ML._potenciaML = txt_ml1.Text;
                ML._frequencia = int.Parse(txt_f.Text);
                ML._qtdML = int.Parse(cmb_ml1.Text);
                ML._corrente = int.Parse(txt_c.Text);
                ML.inserir();
            }
            finally
            {
                MessageBox.Show("Informações cadastradas!!!");
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                ML._potenciaML = txt_ml1.Text;
                ML._frequencia = int.Parse(txt_f.Text);
                ML._qtdML = int.Parse(cmb_ml1.Text);
                ML._corrente = int.Parse(txt_c.Text);
                ML._equipamento_codigoML = int.Parse(txt_cod.Text);
                ML.editar();
            }
            finally
            {
                MessageBox.Show("Informações alteradas!!!");
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {

                ML._equipamento_codigoML = int.Parse(txt_cod.Text);
                ML.excluir();
            }
            finally
            {
                MessageBox.Show("Informações excluidas!!!");
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
