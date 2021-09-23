using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;//biblioteca da conexao do sql.
using MySql.Data.MySqlClient;//biblioteca da conexao do sql.

namespace Design_Dashboard_Modern
{
    class roteadorCl : conexao
    {
        private int equipamento_codigoR;
        private string potenciaR;

        private int qtdR;
        private int corrente;
        private int frequencia;
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


        public int _equipamento_codigoR
        {
            get
            {
                return equipamento_codigoR;
            }
            set
            {
                equipamento_codigoR = value;
            }
        }

        public string _potenciaR
        {
            get
            {
                return potenciaR;
            }
            set
            {
                potenciaR = value;
            }
        }


        public int _qtdR
        {
            get
            {
                return qtdR;
            }
            set
            {
                qtdR = value;
            }
        }

        public void inserir()
        {
            string query = "insert into equipamento_roteador (equipamento_potencia, equipamento_quantidade, equipamento_corrente, equipamento_frequencia) values ('" + _potenciaR + "','" + _qtdR + "', '" + _corrente + "', '" + _frequencia + "')";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }




        public void excluir()
        {
            string query = "delete from equipamento_roteador where equipamento_cod = '" + _equipamento_codigoR + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }


        public void editar()
        {
            string query = "update equipamento_roteador set equipamento_potencia ='" + _potenciaR + "', equipamento_quantidade ='" + _qtdR + "', equipamento_corrente ='" + _corrente + "', equipamento_frequencia = '" + _frequencia + "' where equipamento_cod = '" + _equipamento_codigoR + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}

