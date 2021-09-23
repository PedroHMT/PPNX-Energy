using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;//biblioteca da conexao do sql.
using MySql.Data.MySqlClient;//biblioteca da conexao do sql.


namespace Design_Dashboard_Modern
{
    public partial class painelControle : Form 
    {
        public painelControle()
        {
            InitializeComponent();
        }
        int qtd_h;
        public string equipamento_potencia;
        public string equipamento_hora;
        public string equipamento_quantidade;
        public string equipamento_taxa;
        public string cod_equipamento;
      
        
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
       
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Cadastro_de_Equipamentos form = new Cadastro_de_Equipamentos();
            form.Show();
        }

        private void MenuTop_Paint(object sender, PaintEventArgs e)
        {

        }

        funcaohora H = new funcaohora();
        private void timer1_Tick(object sender, EventArgs e)
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "SELECT equipamento_status FROM equipamentos WHERE equipamento_cod = 2 || equipamento_cod = 1";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            String r0, r1, r2, r3, r4;
            r0  = dt.Rows[0]["equipamento_status"].ToString();
            r1 = dt.Rows[1]["equipamento_status"].ToString();
            r2 = dt.Rows[2]["equipamento_status"].ToString();
            r3 = dt.Rows[3]["equipamento_status"].ToString();
            r4 = dt.Rows[4]["equipamento_status"].ToString();

            if (r0 == "Ligado")
            {
                btn_status_l1.Text = "Ligado";
                btn_status_l1.BackColor = Color.Green;
            }
            else if(r0 == "Desligado")
            {
                btn_status_l1.Text = "Desligado";
                btn_status_l1.BackColor = Color.Red;
            }
            if (r1 == "Ligado")
            {
                btn_status_l2.Text = "Ligado";
                btn_status_l2.BackColor = Color.Green;
            }
            else if (r1 == "Desligado")
            {
                btn_status_l2.Text = "Desligado";
                btn_status_l2.BackColor = Color.Red;
            }
            if (r2 == "Ligado")
            {
                btn_status_l3.Text = "Ligado";
                btn_status_l3.BackColor = Color.Green;
            }
            else if (r2 == "Desligado")
            {
                btn_status_l3.Text = "Desligado";
                btn_status_l3.BackColor = Color.Red;
            }
            if (r3 == "Ligado")
            {
                btn_status_l4.Text = "Ligado";
                btn_status_l4.BackColor = Color.Green;
            }
            else if (r3 == "Desligado")
            {
                btn_status_l4.Text = "Desligado";
                btn_status_l4.BackColor = Color.Red;
            }
            if (r4 == "Ligado")
            {
                btn_status_l5.Text = "Ligado";
                btn_status_l5.BackColor = Color.Green;
            }
            else if (r4 == "Desligado")
            {
                btn_status_l5.Text = "Desligado";
                btn_status_l5.BackColor = Color.Red;
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PanelChart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_consdados_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
           
        }
        /*
        public void calc()
            {
                MySqlConnection conn = null;
                string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
                conn = new MySqlConnection(strConn);
                conn.Open();
                string mSQL = "select equipamento_taxa, equipamento_potencia, '"+qtd_h+"', '"+qtd+"', (equipamento_potencia*'"+qtd_h+"'*'"+qtd+"'*equipamento_taxa) / 1000 as consumoR$ from  equipamento_lampada where equipamento_cod = 1;";
                MySqlCommand cmd = new MySqlCommand(mSQL, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txt_consdados.Text = dt.Rows[0]["consumoR$"].ToString();
            }
    public void qtdequip()
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "Select count(equipamento_status) as count from equipamentos where equipamento_status = 'Ligado';";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            qtd = int.Parse(dt.Rows[0]["count"].ToString());
           
        }
        public void dadoscalc()
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;DataBase=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            //abre conexão
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "select* from equipamento_lampada where equipamento_cod = 1;";
            //definindo o comando para a conexao a instrução SQL
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //preenchendo o objeto DataTable a partir do DataAdapter
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
        }
        public void exibirregistro(int i)
        {
            equipamento_potencia = "" + dataGridView1[0, i].Value;
            equipamento_hora = "" + dataGridView1[1, i].Value;
            cod_equipamento = "" + dataGridView1[2, i].Value;
            equipamento_taxa = "" + dataGridView1[3, i].Value;
        }*/
        // button2.Text = DateTime.Now.ToString("HH:mm:ss");
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

      public void qtd_hora()
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "SELECT data_fim, data_inicio, (data_fim - data_inicio) as qtd_hora from equipamento_lampada where equipamento_id = 3;"; 
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            qtd_h = int.Parse(dt.Rows[0]["qtd_hora"].ToString());

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_status_l1_Click(object sender, EventArgs e)
        {
            if (btn_status_l1.Text == "Ligado")
            {
                MySqlConnection conn = null;
                string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
                conn = new MySqlConnection(strConn);
                conn.Open();
                string mSQL = "UPDATE equipamentos SET equipamentos.equipamento_status = 'Desligado' WHERE equipamento_id = 1;";
                MySqlCommand cmd = new MySqlCommand(mSQL, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            }
            if (btn_status_l1.Text == "Desligado")
            {
                MySqlConnection conn = null;
                string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
                conn = new MySqlConnection(strConn);
                conn.Open();
                string mSQL = "UPDATE equipamentos SET equipamentos.equipamento_status = 'Ligado' WHERE equipamento_id = 1;";
                MySqlCommand cmd = new MySqlCommand(mSQL, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            }
        }
    }
}
