using System;

namespace EncaixaOuNao
{
    class Program {

    static void Main(string[] args)
    {
            Console.Write("Digite a quantidade de casos que deseja realizar os testes: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite 2 números separados com espaço para realizar o teste: ");
                string[] v = Console.ReadLine().Split(' ');
                string a = v[0];
                string b = v[1];

                if (a.Length > 0 && a.Length <= 1000 && b.Length < 0 && b.Length >= 1000)
                    Console.WriteLine("nao encaixa");
                else if (a.EndsWith(b))
                {
                    Console.WriteLine("encaixa");
                }
                else
                Console.WriteLine("nao encaixa");
                        
            }

        }

    }
}