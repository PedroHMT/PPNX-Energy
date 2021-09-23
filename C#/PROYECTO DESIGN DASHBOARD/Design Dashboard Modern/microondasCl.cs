using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;//biblioteca da conexao do sql.
using MySql.Data.MySqlClient;//biblioteca da conexao do sql.


namespace Design_Dashboard_Modern
{
    class microondasCl : conexao
    {



        private string potenciaMO;
        private int qtdMO;

        private int equipamento_codigoMO;
        private int frequencia;
        private int corrente;
        private int tempo;


        public int _tempo
        {
            get
            {
                return tempo;
            }

            set
            {
                tempo = value;
            }
        }

        public int _frequencia
        {
            get
            {
                return frequencia;
            }
            set
            {
                frequencia = value;
            }
        }

        public int _corrente
        {
            get
            {
                return corrente;
            }
            set
            {
                corrente = value;
            }
        }
        public string _potenciaMO
        {
            get
            {
                return potenciaMO;
            }
            set
            {
                potenciaMO = value;
            }

        }

        public int _qtdMO
        {
            get
            {
                return qtdMO;
            }
            set
            {
                qtdMO = value;
            }
        }


        public int _equipamento_codigoMO
        {
            get
            {
                return equipamento_codigoMO;
            }
            set
            {
                equipamento_codigoMO = value;
            }
        }
        public void inserir()
        {
            string query = "insert into equipamento_microondas (equipamento_potencia, equipamento_quantidade, equipamento_corrente, equipamento_frequencia) values ('" + _potenciaMO + "','" + _qtdMO + "', '" + _corrente + "', '" + _frequencia + "')";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }




        public void excluir()
        {
            string query = "delete from equipamento_microondas where equipamento_cod = '" + _equipamento_codigoMO + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }


        public void editar()
        {
            string query = "update equipamento_microondas set equipamento_potencia ='" + _potenciaMO + "', equipamento_quantidade='" + _qtdMO + "', equipamento_corrente ='" + _corrente + "', equipamento_frequencia = '" + _frequencia + "' where equipamento_cod = '" + _equipamento_codigoMO + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }



    }
}
