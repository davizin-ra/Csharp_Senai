namespace Aula07;

class Program
{
    static void Main(string[] args)
    {

        static string VerAprovados(double nota){
            if(nota >= 7){
                return "Aprovado";
            }
            else{
                return "Reprovado";
            }
        }

        string[] alunos = new string[3];
        double[] notas = new double[3];

        for(int i = 0; i < alunos.Length; i++){
            Console.WriteLine("\nDigite o nome do aluno:");
            alunos[i] = Console.ReadLine();

            Console.WriteLine($"Digite a nota de {alunos[i]}");
            notas[i] = double.Parse(Console.ReadLine());
        }

        for(int i = 0; i < alunos.Length; i++){
            Console.WriteLine($"\nAluno: {alunos[i]} \nNota: {notas[i]} \nSituação: {VerAprovados(notas[i])}");
        }

    }
}
