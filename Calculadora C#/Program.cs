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

    // Funções da calculadora
    static void Soma()
    {
     Console.WriteLine("Escreva o Primeiro número:");
     double a = double.Parse(Console.ReadLine());
     Console.WriteLine("Escreva o segundo número:");
     double b = double.Parse(Console.ReadLine());

     double resultado = a + b;
     Console.WriteLine($"Resultado: {resultado} ");
    }

    static void Subtracao()
    {
     Console.WriteLine("Escreva o Primeiro número:");
     double a = double.Parse(Console.ReadLine());
     Console.WriteLine("Escreva o segundo número:");
     double b = double.Parse(Console.ReadLine());

     double resultado = a - b;
     Console.WriteLine($"Resultado: {resultado} ");

    }

    static void Multiplicacao()
    {
     Console.WriteLine("Escreva o Primeiro número:");
     double a = double.Parse(Console.ReadLine());
     Console.WriteLine("Escreva o segundo número:");
     double b = double.Parse(Console.ReadLine());

     double resultado = a * b;
     Console.WriteLine($"Resultado: {resultado} ");
    }

    static void Divisao()
    {
      Console.WriteLine("Escreva o Primeiro número:");
     double a = double.Parse(Console.ReadLine());
     Console.WriteLine("Escreva o segundo número:");
     double b = double.Parse(Console.ReadLine());

     double resultado = a / b;
     Console.WriteLine($"Resultado: {resultado} ");
       
    }

    static void Potencia()
    {
     Console.WriteLine("Escreva o Primeiro número:");
     double a = double.Parse(Console.ReadLine());
     Console.WriteLine("Escreva o segundo número:");
     double b = double.Parse(Console.ReadLine());
      
      double resultado = Math.Pow(a, b );
      Console.WriteLine($"Resultado: {resultado} ");
    }

    // Aqui depois você pode guardar e mostrar histórico
    static void MostrarHistorico()
    {
        Console.WriteLine("Histórico ainda não implementado.");
    }
}



