using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula09___Projeto_Passagens.models.auth
{
    public class Login
    {
        private string senhaC = "123456";
        public bool autenticado = false;

        public bool fazerLogin(string senha)
        {
            if (senha == senhaC){
                autenticado = true;
            }
            else{
                autenticado = false;
            }
            return autenticado;
        }

    }
}