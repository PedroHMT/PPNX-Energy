using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Design_Dashboard_Modern
{
    public partial class lampada : Form
    {
        public lampada()
        {
            InitializeComponent();
        }

        lampadaCL l = new lampadaCL();
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if(cb_tipol.Text == "Incandescente")
                {
                    l.equipamento_cod = 1;
                }
                else if(cb_tipol.Text == "Fluorescente")
                {
                    l.equipamento_cod = 2;
                }
                l.usuario_cod = int.Parse(login.id_usuario);
                l.equipamento_status = "Desligado";
                l.equipamento_hora = 2;
                l.inserir();
            }
            finally
            {
                MessageBox.Show("INFO: Equipamento Cadastrado.");
            }
        }

        public void calcularquantlamp()
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "Select count(*) as count from equipamentos where equipamento_usuario_cod = '" + login.id_usuario + "';";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int qtdlamp = int.Parse(dt.Rows[0]["count"].ToString());
            if (qtdlamp >= 5)
            {
                cb_tipol.Enabled = false;
            }
            else if (qtdlamp<5 && qtdlamp > 0)
            {
                cb_tipol.Enabled = true;
            }
            txt_qtdl.Text = dt.Rows[0]["count"].ToString();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            
        }

        private void PanelChart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Cadastro_de_Equipamentos form = new Cadastro_de_Equipamentos();
            form.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Inicial form = new Inicial();
            form.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            painelControle form = new painelControle();
            form.Show();
            Close();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            usuarioX form = new usuarioX();
            form.Show();
            Close();
        }

        private void cmb_l1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            calcularquantlamp();
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
