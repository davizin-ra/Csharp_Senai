namespace Projeto_Sistema_de_cursos;

class Program
{
    static void Main(string[] args)
    {
        List<Curso> cursos = new List<Curso>{
            new Tecnico("Desenvolvimento de Sistemas", 360),
            new Superior("CyberSegurança", 500)
        };

        foreach(var curso in cursos){
            curso.exibirResumo();
        }
    }
}
