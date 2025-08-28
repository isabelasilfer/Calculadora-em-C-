using System;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("CALCULADORA C#");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Potência");
            Console.WriteLine("6 - Histórico");
            Console.WriteLine("7 - Limpar Tela");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
{
    case "1":
        Soma();
        break;
    case "2":
        Subtracao();
        break;
    case "3":
        Multiplicacao();
        break;
    case "4":
        Divisao();
        break;
    case "5":
        Potencia();
        break;
    case "6":
        MostrarHistorico();
        break;
    case "7":
        Console.Clear();
        break;
    case "0":
        continuar = false;
        break;
    default:
        Console.WriteLine("Opção inválida!");
        break;
}


            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
        }
    }

    
    static void Soma()
    {
  
    }

    static void Subtracao()
    {


    }

    static void Multiplicacao()
    {
   
    }

    static void Divisao()
    {
    
       
    }

    static void Potencia()
    {
  
    }

  
    static void MostrarHistorico()
    {
        Console.WriteLine("Histórico ainda não implementado.");
    }
}




