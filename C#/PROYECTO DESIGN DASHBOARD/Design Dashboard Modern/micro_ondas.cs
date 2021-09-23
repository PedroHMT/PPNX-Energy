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
    public partial class micro_ondas : Form
    {
        public micro_ondas()
        {
            InitializeComponent();
        }

        private void PanelChart_Paint(object sender, PaintEventArgs e)
        {

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
