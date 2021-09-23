using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;//Biblioteca da conexão do Sql.
using MySql.Data.MySqlClient;//Biblioteca da conexão do Sql.

namespace Design_Dashboard_Modern
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public static string id_usuario;
        public static string usuariio;
        public static string usuario_cpf;
        public static string usuario_email;
        public static string usuario_telefone;
        string sennha;
        private void btn_login_Click(object sender, EventArgs e)
        {
            usuariio = txt_e_us.Text;
            sennha = txt_s_us.Text;

            MySqlConnection conn = null;
            string strConn = @"Server = localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "select *, count(user_nome) from usuarios where user_email = '" + usuariio + "' and user_senha = '" + sennha + "'";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            id_usuario = dt.Rows[0]["user_id"].ToString();
            usuariio = dt.Rows[0]["user_nome"].ToString();
            usuario_cpf = dt.Rows[0]["user_cpf"].ToString();
            usuario_email = dt.Rows[0]["user_email"].ToString();
            usuario_telefone = dt.Rows[0]["user_telefone"].ToString();
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            int registro;
            registro = count;

            if (registro == 1)
            {
                Inicial formulario = new Inicial();
                formulario.Show();
                this.Hide();
            }
            else if (txt_e_us.Text == "admin" && txt_s_us.Text == "admin")
            {
                Form1 formulario = new Form1();
                formulario.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Usuário e Senhas Inválidos", "Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            

        }

        private void PanelChart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Wrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Restaurar_Click(object sender, EventArgs e)
        {

        }

        private void Minimizar_Click(object sender, EventArgs e)
        {

        }

        private void Maximizar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_s_us_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_e_us_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void SidebarWrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LineaSidebar_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {

        }
    }
}
