using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;//biblioteca da conexao do sql.
using MySql.Data.MySqlClient;//biblioteca da conexao do sql.

namespace Design_Dashboard_Modern
{
    class usuarioXcl : conexao
    {
        private int _id;
        private string _nome;
        private string _email;
        private string _telefone;
        private string _senha;

       public int id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        public string telefone
        {
            get
            {
                return _telefone;
            }
            set
            {
                _telefone = value;
            }
        }

        public string password
        {
            get
            {
                return _senha;
            }
            set
            {
                _senha = value;
            }
        }

        public void alterar()
        {
            string query = "UPDATE usuarios SET user_nome = '" + nome + "', user_email = '" + email + "', user_telefone = '" + telefone + "', user_senha = '" + password + "' WHERE user_id = " + login.id_usuario;
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }


    }
}
