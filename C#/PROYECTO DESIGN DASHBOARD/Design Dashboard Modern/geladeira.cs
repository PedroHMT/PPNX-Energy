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
    public partial class geladeira : Form
    {
        public geladeira()
        {
            InitializeComponent();
        }

        private void PanelChart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        geladeiraCl gl = new geladeiraCl();
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                gl._potencia = txt_g1.Text;
                gl._qtd = int.Parse(cmb_g1.Text);
                gl._frequencia = int.Parse(txt_gf.Text);
                gl._corrente = int.Parse(txt_gc.Text);
                gl.inserir();

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
                gl._potencia = txt_g1.Text;
                gl._qtd = int.Parse(cmb_g1.Text);
                gl._frequencia = int.Parse(txt_gf.Text);
                gl._corrente = int.Parse(txt_gc.Text);
                gl._equipamento_codigo = int.Parse(txt_cod.Text);
                gl.editar();

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
                gl._equipamento_codigo = int.Parse(txt_cod.Text);
                gl.excluir();

            }
            finally
            {
                MessageBox.Show("Informações apagadas com sucesso");
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
