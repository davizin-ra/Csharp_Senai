using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Sistema_de_cursos
{
    public class Superior : Curso
    {
        public Superior(string nomeConst, int horasConst) : base(nomeConst, horasConst)
        {
        }

        public override double calcularPreco(){
            return horas * 40;
        }
    }
}