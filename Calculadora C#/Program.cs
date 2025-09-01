using System;
using System.Collections.Generic;
using System.Data; // Necessário para usar DataTable

class Program
{
    // Lista para armazenar o histórico
    static List<string> historico = new List<string>();

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
            Console.WriteLine("8 - Parênteses (expressão completa)");
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
                case "8":
                    Parenteses();
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

    // Operação de Adição
    static void Soma()
    {
        Console.WriteLine("Escreva quatro números:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());

        double resultado = a + b + c + d;
        Console.WriteLine($"Resultado: {resultado} ");
        historico.Add($"{a} + {b} + {c} + {d} = {resultado}");
    }

    // Operação de Subtração
    static void Subtracao()
    {
        
    }

    // Operação de Multiplicação
    static void Multiplicacao()
    {
       
    }

    // Operação de Divisão
    static void Divisao()
    {

    }

    // Operação de Potência
    static void Potencia()
    {
       
    }

    // Operação com uso de parênteses
    static void Parenteses()
    {
       
    }

    // Mostrar histórico
    static void MostrarHistorico()
    {
        Console.WriteLine("Histórico de Operações:");

        if (historico.Count == 0)
        {
            Console.WriteLine("Nenhuma operação realizada ainda.");
        }
        else
        {
            foreach (string item in historico)
            {
                Console.WriteLine(item);
            }
        }
    }
}

