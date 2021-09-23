using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;//biblioteca da conexao do sql.
using MySql.Data.MySqlClient;//biblioteca da conexao do sql.

namespace Design_Dashboard_Modern
{
    class televisaoCl : conexao
    {
        private string potenciaT;
        private int equipamento_codigoT;

        private int qtdT;
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

        public string _potenciaT
        {
            get
            {
                return potenciaT;
            }
            set
            {
                potenciaT = value;
            }
        }


        public int _equipamento_codigoT
        {
            get
            {
                return equipamento_codigoT;
            }
            set
            {
                equipamento_codigoT = value;
            }
        }

        public int _qtdT
        {
            get
            {
                return qtdT;
            }
            set
            {
                qtdT = value;
            }
        }


        public void inserir()
        {
            string query = "insert into equipamento_televisao (equipamento_potencia, equipamento_quantidade, equipamento_frequencia, equipamento_corrente) values ('" + _potenciaT + "','" + _qtdT + "', '" + _frequencia + "','" + _corrente + "')";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }




        public void excluir()
        {
            string query = "delete from equipamento_televisao where equipamento_cod = '" + _equipamento_codigoT + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }


        public void editar()
        {
            string query = "update equipamento_televisao set equipamento_potencia ='" + _potenciaT + "', equipamento_quantidade ='" + _qtdT + "', equipamento_corrente = '" + _corrente + "', equipamento_frequencia = '" + _frequencia + "' where equipamento_cod = '" + _equipamento_codigoT + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }



    }
}