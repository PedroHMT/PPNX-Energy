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
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        int qtd;
        //int qtd_h
      
        public string equipamento_potencia;
        public string equipamento_hora;
        public string equipamento_quantidade;
        public string equipamento_taxa;
        public string cod_equipamento;


        private void MenuTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int limite = 8;//Número de barras;

            string dados = textBox1.Text; // Variavel que pega o valor do arduino


            chart1.Series[0].Points.AddY(dados);//Adiciona o valor lido como um novo Y;



            if (chart1.Series[0].Points.Count > limite)

            {

                chart1.Series[0].Points.RemoveAt(0);//Remova o primeiro ponto.

                chart1.Update();//Atualiza o grafico.



            }
            qtdequip();
            calc();
        }

        private void PanelChart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calc();
        }

       

        public void calc()
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=ppnxenergy;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "SELECT equipamentos_cods.equip_taxa, equipamentos_cods.equip_potencia, SUM((equip_taxa*" + qtd + "*equip_potencia)/1000) as consumo FROM equipamentos_cods INNER JOIN equipamentos ON equipamentos.equipamento_cod = equipamentos_cods.equip_id;";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            textBox1.Text = dt.Rows[0]["consumo"].ToString();
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Cadastro_de_Equipamentos form = new Cadastro_de_Equipamentos();
            form.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            painelControle form = new painelControle();
            form.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            usuarioX form = new usuarioX();
            form.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            consumo form = new consumo();
            form.Show();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}

