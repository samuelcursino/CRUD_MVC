﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MVC_SamuelCursino_MateuSilva.DAL
{
    class UtilsDal
    {
        public static MySqlConnection GetConnection()
        {
            // objeto "builder" que contém dados de conexão
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Database = "usuarios",
                UserID = "root",
                Password = ""
            };

            // criar a conexão
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();

            return connection;
        }   

        /* Retorna a chave primaria de uma tabela do banco de dados a partir de uma palavra chave
         * e de uma coluna da tabela.
         * Parâmetros:
         * textKey - palavra chave utilizada como WHERE da SQL
         * table - tabela a ser consultada
         * field - campo a ser retornado e também utilizado na consulta do WHERE
         * returnField - campo a ser retornado após a consulta
         * 
         * Retornos:
         * Retorna a PK em caso de ok e -1 em caso de erro
         */
        public int PrimaryKey(string returnField, string table, string field, string textKey)
        {
            // conectar ao banco de dados
            try
            {
                // criar conexão
                MySqlConnection conn = UtilsDal.GetConnection();

                //verificar se a conexão está ok
                //aqui verificamos a propriedade "State" do objeto "conn" com a
                // propriedade "Open" de "ConnectioState"
                if (conn.State == ConnectionState.Open)
                {
                    //pesquisa no banco se o usuário existe
                    string sql = $"SELECT {returnField} FROM {table} " +
                                $" WHERE " +
                                $" {field} = '{textKey}' ";

                    MySqlCommand retorno = new MySqlCommand(sql, conn);

                    // executar no banco a query
                    MySqlDataReader reader = retorno.ExecuteReader();

                    if (reader.Read())
                    {
                        return (int)reader[0];
                    }
                }
            }
            catch (System.Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return -1;
        }
    }
}
