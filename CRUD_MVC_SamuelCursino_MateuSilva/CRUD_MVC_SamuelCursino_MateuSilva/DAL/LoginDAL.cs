using CRUD_MVC_SamuelCursino_MateuSilva.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MVC_SamuelCursino_MateuSilva.DAL
{
    class LoginDAL
    {
        //criar im método que consulta o banco e retorna se o
        // usuário foi encontrado ou não

        // neste método utilizamos como parâmetro um objeto do tipo LoginDTO
        // este objeto contém todos atributos e métodos pertencentes ao objeto que será criado
        // na camada "UI" na classe do formulário de Login.
        // Vamos chamar de GetLoginDAL para podermos diferenciar facilmente o método e sua camada
        public bool GetLoginDAL(LoginDTO loginDTO)
        {
            // tentar conectar ao banco de dados
            try
            {
                // criar conexão
                MySqlConnection conn = UtilsDal.GetConnection();

                // verificar se a conexão está ok
                // aqui verificamos a propriedade "State" do objeto "conn" com a
                // propriedade "Open" de "ConnectionState"
                if (conn.State == ConnectionState.Open)
                {
                    // pesquisa no banco se o usurario existe
                    string sql = $"SELECT * FROM cad_usuarios" +
                                 $" WHERE " +
                                 $"email = '{loginDTO.Email}' " +
                                 $"AND " +
                                 $"senha = '{loginDTO.Senha}' ";

                    MySqlCommand retorno = new MySqlCommand(sql, conn);
                    //executar no banco a query
                    MySqlDataReader reader = retorno.ExecuteReader();
                    // se houver conteúdo de resposta da pesquisa no banco retorna true
                    if (reader.Read())
                    {
                        return true;
                    }

                }
            }
            catch (System.Exception erro)
            {
                // apresenta ao usuário uma mensagem de erro
                // caso haja algum problema na conexão com o banco de dados
                MessageBox.Show(erro.Message);
            }
            return false;
        }   
    }
}
