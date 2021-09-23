using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;//biblioteca da conexao do sql.
using MySql.Data.MySqlClient;//biblioteca da conexao do sql.

namespace Design_Dashboard_Modern
{
    class chuveiroCl : conexao
    {
        private int equipamento_codigoCH;
        private string potenciaCH;

        private int qtdCH;
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
        public int _equipamento_codigoCH
        {
            get
            {
                return equipamento_codigoCH;
            }
            set
            {
                equipamento_codigoCH = value;
            }
        }

        public string _potenciaCH
        {
            get
            {
                return potenciaCH;
            }
            set
            {
                potenciaCH = value;
            }
        }


        public int _qtdCH
        {
            get
            {
                return qtdCH;
            }
            set
            {
                qtdCH = value;
            }
        }

        public void inserir()
        {
            string query = "insert into equipamento_chuveiro (equipamento_potencia, equipamento_quantidade,  equipamento_corrente, equipamento_frequencia, equipamento hora) values ('" + _potenciaCH + "','" + _qtdCH + "',  '" + _corrente + "', '" + _frequencia + "','"+-tempo+"')";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }




        public void excluir()
        {
            string query = "delete from equipamento_chuveiro where equipamento_cod = '" + _equipamento_codigoCH + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }


        public void editar()
        {
            string query = "update equipamento_chuveiro set equipamento_potencia ='" + _potenciaCH + "', equipamento_quantidade ='" + _qtdCH + "', equipamento_corrente = '" + _corrente + "', equipamento_frequencia = '" + _frequencia + "', equipamento_hora = '"+_tempo+"' where equipamento_cod = '" + _equipamento_codigoCH + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }


    }
}

