using System;

class Desafio {
  public static void Main() {
    int quantidadeEntradas = 3;
    
    while (quantidadeEntradas > 0) {
      Console.WriteLine("Insira um número entre 1 e 500:");
      var numeroQuantidade = Int32.Parse(Console.ReadLine());
        
      if (numeroQuantidade >= 1 && numeroQuantidade <= 500) {
                Console.Write("Insira a velocidade das tartarugas separadas por espaço: ");
                string[] tartarugas = Console.ReadLine().Split(" ");
        var maiorVelocidade = Int32.Parse(tartarugas[0]);

            for (int i = 0; i < tartarugas.Length; i++)
            {
            var tartaruga = Int32.Parse(tartarugas[i]);

            if (maiorVelocidade < tartaruga)
            {
            maiorVelocidade = tartaruga;
            }
            }

        if(maiorVelocidade < 10) {
            Console.WriteLine("Nível 1");
        } else if (maiorVelocidade >= 10 && maiorVelocidade < 20) {
          Console.WriteLine("Nível 2");
        } else if ( maiorVelocidade >= 20) {
          Console.WriteLine("Nível 3");
        }
        quantidadeEntradas--;
      } else {
                Console.WriteLine("Valor inválido!");
      }
    }
  }
}