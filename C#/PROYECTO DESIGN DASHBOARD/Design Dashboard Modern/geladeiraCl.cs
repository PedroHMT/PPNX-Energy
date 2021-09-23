using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;//biblioteca da conexao do sql.
using MySql.Data.MySqlClient;//biblioteca da conexao do sql.

namespace Design_Dashboard_Modern
{
    class geladeiraCl : conexao
    {
        private string potencia;
        private int qtd;

        private int equipamento_codigo;
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



        public string _potencia
        {
            get
            {
                return potencia;
            }
            set
            {
                potencia = value;
            }

        }

        public int _qtd
        {
            get
            {
                return qtd;
            }
            set
            {
                qtd = value;
            }
        }



        public int _equipamento_codigo
        {
            get
            {
                return equipamento_codigo;
            }
            set
            {
                equipamento_codigo = value;
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
        public void inserir()
        {
            string query = "insert into equipamento_geladeira (equipamento_potencia,equipamento_quantidade, equipamento_frequencia,equipamento_corrente) values ('" + _potencia + "','" + _qtd + "', '" + _frequencia + "', '" + _corrente + "')";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }




        public void excluir()
        {
            string query = "delete from equipamento_geladeira where equipamento_cod = '" + _equipamento_codigo + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }


        public void editar()
        {
            string query = "update equipamento_geladeira set equipamento_potencia ='" + _potencia + "', equipamento_quantidade ='" + _qtd + "', equipamento_frequencia = '" + _frequencia + "', equipamento_corrente = '" + _corrente + "' where equipamento_cod = '" + _equipamento_codigo + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

    }
}
