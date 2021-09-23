using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;//biblioteca da conexao do sql.
using MySql.Data.MySqlClient;//biblioteca da conexao do sql.

namespace Design_Dashboard_Modern
{
    class maquinalCl : conexao
    {
        private string potenciaML;
        
        private int qtdML;
        private int equipamento_codigoML;
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
        public string _potenciaML
        {
            get
            {
                return potenciaML;
            }
            set
            {
                potenciaML = value;
            }
        }



        public int _qtdML
        {
            get
            {
                return qtdML;
            }
            set
            {
                qtdML = value;
            }
        }

        public int _equipamento_codigoML
        {
            get
            {
                return equipamento_codigoML;
            }
            set
            {
                equipamento_codigoML = value;
            }
        }

        public void inserir()
        {
            string query = "insert into equipamento_maquinal (equipamento_potencia, equipamento_quantidade, equipamento_corrente, equipamento_frequencia) values ('" + _potenciaML + "','" + _qtdML + "', '" + _corrente + "', '" + _frequencia + "')";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }




        public void excluir()
        {
            string query = "delete from equipamento_maquinal where equipamento_cod = '" + _equipamento_codigoML + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }


        public void editar()
        {
            string query = "update equipamento_maquinal set equipamento_potencia ='" + _potenciaML + "', equipamento_quantidade ='" + _qtdML + "', equipamento_corrente ='" + _corrente + "', equipamento_frequencia = '" + _frequencia + "' where equipamento_cod = '" + _equipamento_codigoML + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}
