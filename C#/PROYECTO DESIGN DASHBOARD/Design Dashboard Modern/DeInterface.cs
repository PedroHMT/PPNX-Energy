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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if(Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                SidebarWrapper.Width = 300;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
            }
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            Temporizador.Stop();

            this.chart1.Series["ChartLinea"].Points.AddXY("DOMINGO", 10);
            this.chart1.Series["ChartLinea"].Points.AddXY("SEGUNDA", 20);
            this.chart1.Series["ChartLinea"].Points.AddXY("TERÇA", 30);
            this.chart1.Series["ChartLinea"].Points.AddXY("QUARTA", 40);
            this.chart1.Series["ChartLinea"].Points.AddXY("QUINTA", 50);
            this.chart1.Series["ChartLinea"].Points.AddXY("SEXTA", 40);
            this.chart1.Series["ChartLinea"].Points.AddXY("SABADO", 20);
        }

        private void Grafico_Click(object sender, EventArgs e)
        {

        }

        private void MenuTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SidebarWrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            login form = new login();
            form.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Cadastro_de_Equipamentos form = new Cadastro_de_Equipamentos();
            form.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
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

        private void Wrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelChart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timerChart_Tick(object sender, EventArgs e)
        {
            int limite = 8;//Número de barras;

            string dados = textBox1.Text; // Variavel que pega o valor do arduino


            chart1.Series[0].Points.AddY(dados);//Adiciona o valor lido como um novo Y;



            if (chart1.Series[0].Points.Count > limite)

            {

                chart1.Series[0].Points.RemoveAt(0);//Remova o primeiro ponto.

                chart1.Update();//Atualiza o grafico.



            }
        }
    }
}
