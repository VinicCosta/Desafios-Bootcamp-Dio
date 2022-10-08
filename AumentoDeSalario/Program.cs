﻿using System;  

class minhaClasse { 

  static void Main(string[] args) {  

    double salario = 0.00; 
    double reajuste = 0.00; 
    double novoSalario = 0.00; 
    double percentual = 0.00;

        Console.Write("Digite o valor do salário: R$ ");
        salario = Convert.ToDouble(Console.ReadLine()); 
   
    if(salario < 0) { 
      return; 

    } else if (salario <= 400) { 
      percentual = 0.15; 
      reajuste =  salario * percentual; 
      novoSalario = salario + reajuste; 


    } else if (salario <= 800) { 
      percentual = 0.12; 
      reajuste = salario * percentual;         
      novoSalario = salario + reajuste; 

    } else if (salario <= 1200) { 
      percentual = 0.10; 
      reajuste =  salario * percentual; 
      novoSalario = salario + reajuste; 

    } else if (salario <= 2000) { 
      percentual = 0.07; 
      reajuste = salario * percentual; 
      novoSalario = salario + reajuste; 

    } else { 
      percentual = 0.04; 
      reajuste = salario * percentual; 
      novoSalario = salario + reajuste; 

    } 

    Console.WriteLine("Novo salario: R$ {0:0.00}", novoSalario); 
    Console.WriteLine("Reajuste ganho: R$ {0:0.00}", reajuste); 
    Console.WriteLine("Em percentual: {0} %", percentual * 100); 

  } 
}