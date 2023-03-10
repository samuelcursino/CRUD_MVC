using CRUD_MVC_SamuelCursino_MateuSilva.BLL;
using CRUD_MVC_SamuelCursino_MateuSilva.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MVC_SamuelCursino_MateuSilva
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Capturar os dados digitados pelo usuário no formulário e encaminhar
            // a camada de controle "BLL" para isso é necessário criarmos um objeto que
            // receba esses dados
            LoginDTO loginDTO = new LoginDTO
            {
                Email = txtEmail.Text,
                Senha = txtSenha.Text
            };

            // realizar a chamada do método de pesquisa em controle
            LoginBLL login = new LoginBLL();
            bool retorno = login.GetLoginBLL(loginDTO);

            // Se a variável de retorno for true exibe a mensagem de "Login Ok" ao usuário
            if (retorno)
            {
                MessageBox.Show("Login Ok");
            }
            else
            {
                //caso não seja possível realizar o login exibe a mensagem
                MessageBox.Show("Não foi possível realizar o login, tente novamente!");
            }
        }
    }
}
