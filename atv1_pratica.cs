using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

class progam
{
    static void Main()

    {
        int[][] NotasAluno = new int[3][];

        NotasAluno[0] = new int[] { 70, 85, 90 };
        NotasAluno[1] = new int[] { 60, 45 };
        NotasAluno[2] = new int[] { 80, 95, 100, 88 };

        Console.WriteLine("---Estritiras de notas---");
        for (int i = 0; i < NotasAluno.Length; i++)
        {
            Console.Write($"Aluno {i}:");
            for (int j = 0; j < NotasAluno[i].Length; j++)
            {
                Console.Write(NotasAluno[i][j] + "");
            }
            Console.WriteLine();
        }



        // 3. Testando a Busca Sequencial
        Console.WriteLine("\nDigite uma nota para buscar:");
        int notaBusca = int.Parse(Console.ReadLine());
        bool encontrada = BuscaSequencial(NotasAluno, notaBusca);
        if (encontrada)
            Console.WriteLine($"A nota {notaBusca} foi encontrada no sistema.");
        else
            Console.WriteLine($"A nota {notaBusca} Nao consta nos registros.");
    } 
    static bool BuscaSequencial(int[][] matriz, int ValorProcurado)
    {
        // Percorre cada linha (aluno)
        for (int i = 0;i < matriz.Length;i++)
        {
            //Percorre cada coluna (notas do aluno)
            for(int j = 0;j < matriz[i].Length;j++)
            if (matriz[i][j] == ValorProcurado)
            {
                Console.WriteLine($"[DEBUG] Encontrado no Aluno {i}, Prova {j}");
                return true;
            }



        }


    
      // Se percorreu tudo e não achou
      return false;
    }

}
