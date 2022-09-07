using System;

namespace CalculoComProduto
{
class Program
{
        
static void Main(string[] args)
{
            Console.Write("Entre com um valor de um número inteiro: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int p = 1;
            int s = 0;
        while (n > 0){
             int l = n % 10;
             p *= l;
             s += l;
             n /= 10;
           }
            Console.Write("O seu resultrado é: ");
            Console.WriteLine(p-s);
        }
    }
}