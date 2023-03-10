using CRUD_MVC_SamuelCursino_MateuSilva.DAL;
using CRUD_MVC_SamuelCursino_MateuSilva.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MVC_SamuelCursino_MateuSilva.BLL
{
    class LoginBLL
    {
        public bool GetLoginBLL(LoginDTO loginDTO)
        {
            // validar usuario
            // realizar a chamada do método de pesquisa de login na cmada DAL
            LoginDAL login = new LoginDAL();
            bool retorno = login.GetLoginDAL(loginDTO);
            // Se o retorno do método de pesquisa da camada DAL for verdadeiro retorna true  
            if (retorno)
            {
                return true;
            }
            return false;
        }
    }
}
