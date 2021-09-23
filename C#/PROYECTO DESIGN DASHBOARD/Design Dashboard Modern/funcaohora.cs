using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;//biblioteca da conexao do sql.
using MySql.Data.MySqlClient;//biblioteca da conexao do sql.


namespace Design_Dashboard_Modern
{
    class funcaohora : conexao
    {
        public string dataI;
        private string dataF;
        private string id;

        public string _dataI
        {
            get
            {
                return dataI;
            }
            set
            {
                dataI = value;
            }
        }

        public string _dataF
        {
            get
            {
                return dataF;
            }
            set
            {
                dataF = value;
            }
        }
        public string _id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

       /* public void hora()
        {
            string query = "insert into equipamento_lampada (data_inicio, data_fim,equipamento_id) values ('" + _dataI + "','" + _dataF + "','"+_id+"')";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }*/
    }
}
