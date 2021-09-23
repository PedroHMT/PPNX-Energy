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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void Wrapper_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                login form = new login();
                form.Show();
                this.Hide();
            }
        }
    }
}
