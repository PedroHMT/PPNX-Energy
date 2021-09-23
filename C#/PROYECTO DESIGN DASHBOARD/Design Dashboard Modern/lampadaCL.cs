using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;//biblioteca da conexao do sql.
using MySql.Data.MySqlClient;//biblioteca da conexao do sql.

namespace Design_Dashboard_Modern
{
    class lampadaCL : conexao
    {
        private int _equipamento_cod;
        private int _usuario_cod;
        private string _equipamento_status;
        private int _equipamento_hora;


       public int equipamento_cod
        {
            get
            {
                return _equipamento_cod;
            }
            set
            {
                _equipamento_cod = value;
            }
        }

        public int usuario_cod
        {
            get
            {
                return _usuario_cod;
            }
            set
            {
                _usuario_cod = value;
            }
        }

        public string equipamento_status
        {
            get
            {
                return _equipamento_status;
            }
            set
            {
                _equipamento_status = value;
            }
        }

        public int equipamento_hora
        {
            get
            {
                return _equipamento_hora;
            }
            set
            {
                _equipamento_hora = value;
            }
        }


        public void inserir()
        {
            string query = "INSERT INTO equipamentos (equipamento_cod, equipamento_usuario_cod, equipamento_status, equipamento_hora) values ('" + equipamento_cod + "','" + usuario_cod + "', '" + equipamento_status + "', '" + equipamento_status + ", 1')";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

    }
}
