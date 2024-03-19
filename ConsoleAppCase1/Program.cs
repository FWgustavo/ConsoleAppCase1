using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCase1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação que deseja utilizar (+,-,*,/): ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    double res = n1 + n2;
                    Console.WriteLine("O resultado é: " +res); 
                    break;
                case "-":
                    res = n1 - n2;
                    Console.WriteLine("O resultado é: "+res); 
                    break;
                case "*":
                    res = n1 * n2;
                    Console.WriteLine("O resultado é: " + res);
                break;
                case "/":
                    res = n1 / n2;
                    Console.WriteLine("O resultado é: " + res);
                break;
                     
                default:
                    Console.WriteLine("Opção inválida");
                break;
            }
            Console.ReadKey();
        }
    }
}
