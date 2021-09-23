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
    public partial class consumo : Form
    {
        public consumo()
        {
            InitializeComponent();
        }

        int qtd;
        //int qtd_h
        public double resultado;
        public double valor1;
        public double valor2;
        public double valor3;
        public string equipamento_potencia;
        public string equipamento_hora;
        public string equipamento_quantidade;
        public string equipamento_taxa;
        public string cod_equipamento;

        private void PanelChart_Paint(object sender, PaintEventArgs e)
        {

        }

        //Lampada

        public void calc()
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "SELECT equipamentos_cods.equip_taxa, equipamento_hora AS qtdHora, equipamentos_cods.equip_potencia, SUM((equip_taxa*" + qtd + "*equip_potencia)/1000) as consumoR$ FROM equipamentos_cods INNER JOIN equipamentos ON equipamentos.equipamento_cod = equipamentos_cods.equip_id";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            textBox1.Text = "R$ " + dt.Rows[0]["consumoR$"].ToString() + " (" + dt.Rows[0]["qtdHora"].ToString() + " horas)";
        }

        public void qtdequip()
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "SELECT COUNT(equipamento_status) AS count FROM equipamentos WHERE equipamento_status = 'Ligado';";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            qtd = int.Parse(dt.Rows[0]["count"].ToString());

        }

        //Chuveiro

        public void calcChuv()
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "select equipamento_taxa, equipamento_potencia, '" + qtd + "', (equipamento_potencia*'" + qtd + "'*equipamento_taxa) / 10000 as consumoR$ from  equipamento_chuveiro where equipamento_cod = 1;";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            textBox2.Text = dt.Rows[0]["consumoR$"].ToString();
        }

        public void qtdequipChuv()
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "Select count(equipamento_status) as count from equipamentos where equipamento_status = 'Ligado' and equipamento_cod = 8;";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            qtd = int.Parse(dt.Rows[0]["count"].ToString());

        }

        //Maquina de Lavar

        public void calcML()
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "select equipamento_taxa, equipamento_potencia, '" + qtd + "', (equipamento_potencia*'" + qtd + "'*equipamento_taxa) / 10000 as consumoR$ from  equipamento_maquinal where equipamento_cod = 1;";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            textBox4.Text = dt.Rows[0]["consumoR$"].ToString();
        }

        public void qtdequipML()
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "Select count(equipamento_status) as count from equipamentos where equipamento_status = 'Ligado' and equipamento_cod = 9;";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            qtd = int.Parse(dt.Rows[0]["count"].ToString());

        }

        //Geladeira

        public void calcG()
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "select equipamento_taxa, equipamento_potencia, '" + qtd + "', (equipamento_potencia*'" + qtd + "'*equipamento_taxa) / 10000 as consumoR$ from  equipamento_geladeira where equipamento_cod = 1;";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txt_total.Text = dt.Rows[0]["consumoR$"].ToString();
        }

        public void qtdequipG()
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "Select count(equipamento_status) as count from equipamentos where equipamento_status = 'Ligado' and equipamento_cod = 4;";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            qtd = int.Parse(dt.Rows[0]["count"].ToString());

        }

        //Micro Ondas

        public void calcMO()
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "select equipamento_taxa, equipamento_potencia, '" + qtd + "', (equipamento_potencia*'" + qtd + "'*equipamento_taxa) / 10000 as consumoR$ from  equipamento_microondas where equipamento_cod = 1;";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            textBox6.Text = dt.Rows[0]["consumoR$"].ToString();
        }

        public void qtdequipMO()
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "Select count(equipamento_status) as count from equipamentos where equipamento_status = 'Ligado' and equipamento_cod = 6;";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            qtd = int.Parse(dt.Rows[0]["count"].ToString());

        }

        //Televisão

        public void calcT()
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "select equipamento_taxa, equipamento_potencia, '" + qtd + "', (equipamento_potencia*'" + qtd + "'*equipamento_taxa) / 10000 as consumoR$ from  equipamento_televisao where equipamento_cod = 1;";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            textBox7.Text = dt.Rows[0]["consumoR$"].ToString();
        }

        public void qtdequipT()
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "Select count(equipamento_status) as count from equipamentos where equipamento_status = 'Ligado' and equipamento_cod = 7;";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            qtd = int.Parse(dt.Rows[0]["count"].ToString());

        }

        //Roteador

        public void calcR()
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "select equipamento_taxa, equipamento_potencia, '" + qtd + "', (equipamento_potencia*'" + qtd + "'*equipamento_taxa) / 10000 as consumoR$ from  equipamento_roteador where equipamento_cod = 1;";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            textBox3.Text = dt.Rows[0]["consumoR$"].ToString();
        }

        public void qtdequipR()
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "Select count(equipamento_status) as count from equipamentos where equipamento_status = 'Ligado' and equipamento_cod = 5;";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            qtd = int.Parse(dt.Rows[0]["count"].ToString());

        }

        //Computador

        public void calcC()
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "select equipamento_taxa, equipamento_potencia, '" + qtd + "', (equipamento_potencia*'" + qtd + "'*equipamento_taxa) / 10000 as consumoR$ from  equipamento_computador where equipamento_cod = 1;";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            textBox5.Text = dt.Rows[0]["consumoR$"].ToString();
        }

        public void qtdequipC()
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "Select count(equipamento_status) as count from equipamentos where equipamento_status = 'Ligado' and equipamento_cod = 10;";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            qtd = int.Parse(dt.Rows[0]["count"].ToString());

        }

        
        public void sum()
        {
           // textBox9.Text = Convert.ToDouble(TextBox1.Text) * Convert.ToDouble(TextBox2.Text);
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            qtdequip();
            calc();
            txt_total.Text = "R$ " + textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // Double valor1, valor2, valor3, resultado;

            
            
   
                                                                                    
           // textBox9.Text = textBox1.Text * textBox2.Text * textBox3.Text;
            //textBox9.Text = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox3.Text);
            //textBox9.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox3.Text)).ToString();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
