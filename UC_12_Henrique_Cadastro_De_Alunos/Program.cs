// See https://aka.ms/new-console-template for more information
using System;

class CadastroAlunos
{
    const int MAX_ALUNOS = 30;

    static void Main()
    {
        string[] nome = new string[MAX_ALUNOS];
        string[] matricula = new string[MAX_ALUNOS];
        int[] idade = new int[MAX_ALUNOS];
        string[] curso = new string[MAX_ALUNOS];
        double[] nota = new double[MAX_ALUNOS];

        int totalAlunos = 0;

        Console.WriteLine("=== Cadastro de Alunos ===");
        Console.Write("Quantos alunos deseja cadastrar (máximo 30)? ");
        string entrada = Console.ReadLine();

        if (!int.TryParse(entrada, out totalAlunos) || totalAlunos <= 0 || totalAlunos > MAX_ALUNOS)
        {
            Console.WriteLine("Número inválido de alunos. Encerrando.");
            return;
        }

        for (int i = 0; i < totalAlunos; i++)
        {
            Console.WriteLine($"\nAluno {i + 1}:");

            Console.Write("Nome: ");
            nome[i] = Console.ReadLine();

            Console.Write("Matrícula: ");
            matricula[i] = Console.ReadLine();

            Console.Write("Idade: ");
            while (!int.TryParse(Console.ReadLine(), out idade[i]) || idade[i] <= 0)
            {
                Console.Write("Idade inválida. Tente novamente: ");
            }

            Console.Write("Curso (Sistema A, B ou C): ");
            curso[i] = Console.ReadLine();

            Console.Write("Nota final: ");
            while (!double.TryParse(Console.ReadLine(), out nota[i]) || nota[i] < 0 || nota[i] > 10)
            {
                Console.Write("Nota inválida. Digite uma nota entre 0 e 10: ");
            }
        }

       
        int somaIdade = 0;
        for (int i = 0; i < totalAlunos; i++)
        {
            somaIdade += idade[i];
        }
        double mediaIdade = (double)somaIdade / totalAlunos;
        Console.WriteLine($"\nMédia de idade dos alunos: {mediaIdade:F1} anos");

       
        Console.Write("\nDigite a nota de corte para aprovação: ");
        string corteStr = Console.ReadLine();
        if (!double.TryParse(corteStr, out double corte) || corte < 0 || corte > 10)
        {
            Console.WriteLine("Nota de corte inválida.");
            return;
        }

        Console.WriteLine("\n== Alunos Aprovados ==");
        bool algumAprovado = false;
        for (int i = 0; i < totalAlunos; i++)
        {
            if (nota[i] >= corte)
            {
                algumAprovado = true;
                Console.WriteLine($"\nNome: {nome[i]}");
                Console.WriteLine($"Matrícula: {matricula[i]}");
                Console.WriteLine($"Idade: {idade[i]}");
                Console.WriteLine($"Curso: {curso[i]}");
                Console.WriteLine($"Nota: {nota[i]}");
            }
        }

        if (!algumAprovado)
        {
            Console.WriteLine("Nenhum aluno aprovado com base na nota de corte informada.");
        }
    }
}