using System;

 class Program {
    public static void Main(string[] args)
    {
        Console.Write("Digite um número para verificar de ele possuí 3 divisores inteiros: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 0;

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                count++;
            }
        }
            if (count < 3 || count > 3)
            {
                Console.WriteLine(false + " - Este número não possui 3 divisores inteiros.");
            }
            else 
            {
                Console.WriteLine(true + " - Este número possui 3 divisores inteiros.");
            }
        
    }
}