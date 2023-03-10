using CRUD_MVC_SamuelCursino_MateuSilva.DAL;
using CRUD_MVC_SamuelCursino_MateuSilva.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MVC_SamuelCursino_MateuSilva.BLL
{
    class CadastrarUsuarioBLL
    {
        // o método de controle CadastrarUsuario deve validar os dados e chamar o método
        // CadastrarUsuarioDAL() que retorna um booleano a ser tratado pelo método da BLL

        public bool CadastrarUsuario(CadastrarUsuarioDTO usuario)
        {
            // validações...

            // o método CadastrarUsuario da camada BLL deverá, após todas as validações de campos
            // e se tudo estiver ok com os dados recebidos chamar o metodo de cadastrar usuários,
            // CadastrarUsuario() da camada DAL, para isso precisamos que exista um objeto da classe
            // CadastrarUsuarioDAL que permita o acesso ao método.

            CadastrarUsuarioDAL cadUserDal = new CadastrarUsuarioDAL();

            // estando tudo ok com os dados do usuário podemos chamar o método que realiza
            // a gravação de dados da camada DAL
            bool retorno = cadUserDal.CadastrarUsuario(usuario);

            //A variavel de reotrno do metodo CadastrarUsuario() da camada DAL retorna verdadeiro se
            // conseguiu salvar e falso se não, portanto o controle também deve retornar esses valores
            // a quem solicitar para que sejapossível controlar o que está sendo feito.
            if (retorno) return true;

            return false; // retorna falso por padrao
        }
    }
}
