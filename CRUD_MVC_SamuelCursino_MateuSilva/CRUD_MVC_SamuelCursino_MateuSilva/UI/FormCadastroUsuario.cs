using CRUD_MVC_SamuelCursino_MateuSilva.BLL;
using CRUD_MVC_SamuelCursino_MateuSilva.DAL;
using CRUD_MVC_SamuelCursino_MateuSilva.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MVC_SamuelCursino_MateuSilva.UI
{
    public partial class FormCadastroUsuario : Form
    {
        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // para que possamos cadstrar um usuario primeiro precisamos coletar os dados do
            // formulario, e para isso temos o objeto de transporte da camada DTO
            // chamaremos este objeto de "usuario" e iremos atribuir a eles os valores do formulario
            CadastrarUsuarioDTO usuario = new CadastrarUsuarioDTO
            {
                Nome = txtNomeCompleto.Text,
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
                Nivel = cmbNivel.Text
            };

            // chamar o método CadastrarUsuario() da camada BLL
            CadastrarUsuarioBLL cadUserBLL = new CadastrarUsuarioBLL();
            bool retorno = cadUserBLL.CadastrarUsuario(usuario);

            if (retorno)
            {
                MessageBox.Show("usuário cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Usuário não pode ser cadastrado!");
            }
        }

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                // Chama o método de conexão com o banco de dados
                var conn = UtilsDal.GetConnection();

                // verifica se a conexão está ok, por meio da comparaão entre a propriedade
                // state do objeto de conexão e a variável Enum ConnectionState com seu atributo Open
                if (conn.State == ConnectionState.Open)
                {
                    // definimos a variável sql com a query de inserção de dados
                    string sql = $" SELECT * FROM nivel";

                    // o objeto comando possui a conexão e a query a ser executada
                    MySqlCommand comando = new MySqlCommand(sql, conn);

                    //carregar um DataReader com MySqlCommand
                    MySqlDataReader data = comando.ExecuteReader();

                    // Criar uma tabela com os dados
                    DataTable table = new DataTable();

                    // Carrega a tabela com os dados
                    table.Load(data);

                    //informa qual o tipo dado será apresentado no combobox
                    cmbNivel.DisplayMember = "nome";

                    // Carrega os dados no combobox
                    cmbNivel.DataSource = table;

                    // Fecha a conexão com o banco
                    conn.Close();
                }
            }
            catch (System.Exception) // caso ocorra um erro durante a transação com o BD
            {
                MessageBox.Show("Erro ao conectar com o banco de dados FormCadastrarUsuario!");
            }
        }
    }
}
