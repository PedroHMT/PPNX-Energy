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
    public partial class tv : Form
    {
        public tv()
        {
            InitializeComponent();
        }

        televisaoCl T = new televisaoCl();
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                T._potenciaT = txt_tv.Text;
                T._qtdT = int.Parse(cmb_tv.Text);
                T._frequencia = int.Parse(txt_f.Text);
                T._corrente = int.Parse(txt_c.Text);
                T.inserir();

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
                T._potenciaT = txt_tv.Text;
                T._qtdT = int.Parse(cmb_tv.Text);
                T._frequencia = int.Parse(txt_f.Text);
                T._corrente = int.Parse(txt_c.Text);
                T._equipamento_codigoT = int.Parse(txt_cod.Text);
                T.editar();

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

                T._equipamento_codigoT = int.Parse(txt_cod.Text);
                T.excluir();

            }
            finally
            {
                MessageBox.Show("Informações apagadas com sucesso!!!");
            }
        }
    }
}
