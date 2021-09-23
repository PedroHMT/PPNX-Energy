using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;//biblioteca da conexao do sql.
using MySql.Data.MySqlClient;//biblioteca da conexao do sql.

namespace Design_Dashboard_Modern
{
    class conexao
    {
        public MySqlConnection conectar;
        public string servidor;
        public string database;
        public string usuario;
        public string senha;
        //Construindo a conexão//
        public conexao()
        {
            //metodoinicializar//

            inicializar();
        }
        //Inicializar conexao com o sql//
        public void inicializar()
        {
            servidor = "127.0.0.1";
            database = "ppnxenergy";
            usuario = "root";
            senha = "";
            string conexaostring;
            conexaostring = "SERVER=" + servidor + ";" + "DATABASE=" +
            database + ";" + "UID=" + usuario + ";" + "PASSWORD=" + senha + ";";
            conectar = new MySqlConnection(conexaostring);
        }
        //Abrindo a database
        public bool abrirconexao()
        {
            try
            {
                conectar.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        System.Windows.Forms.MessageBox.Show("Não foi possivel conectar");
                        break;
                    case 1045:
                        System.Windows.Forms.MessageBox.Show("Usuario e senha inválidos!Verifique.");
                        break;
                }
                return false;
            }
        }
        public bool fecharconexao()
        {
            try
            {
                conectar.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}