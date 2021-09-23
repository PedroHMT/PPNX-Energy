using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data;//biblioteca da conexao do sql.
using MySql.Data.MySqlClient;//biblioteca da conexao do sql.

namespace Design_Dashboard_Modern
{
    public partial class usuarioX : Form
    {
        public usuarioX()
        {
            InitializeComponent();
        }

        public string user_id;
        public string user_senha;
        public string user_telefone;
        public string user_email;
        public string user_nome;

        usuarioXcl u = new usuarioXcl();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            userdados();

        }
        public void userdados()
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;DataBase=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            //abre conexão
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "SELECT * FROM usuarios WHERE user_id = " + login.id_usuario + ";";
            //definindo o comando para a conexao a instrução SQL
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            user_nome = dt.Rows[0]["user_nome"].ToString();
            user_email = dt.Rows[0]["user_email"].ToString();
            user_telefone = dt.Rows[0]["user_telefone"].ToString();
            user_senha = dt.Rows[0]["user_senha"].ToString();
        }

        public void carregarDados()
        {
            txt_nomeu.Text = user_nome;
            txt_emailu.Text = user_email;
            txt_telefoneu.Text = user_telefone;
            txt_senhau.Text = user_senha;
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

        private void PanelChart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            userdados();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                u.nome = txt_nomeu.Text;
                u.email = txt_emailu.Text;
                u.telefone = txt_telefoneu.Text;
                u.password = txt_senhau.Text;
                u.alterar();
            }
            finally
            {
                MessageBox.Show("INFO: Dados Alterados com Sucesso.");
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void usuarioX_Load(object sender, EventArgs e)
        {
            userdados();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            carregarDados();
        }

        private void bunifuFlatButton4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
