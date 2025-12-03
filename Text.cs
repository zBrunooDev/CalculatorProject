using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public class Text
    {
        
        public void ShowMenu()
        {
            Console.WriteLine("Calculadora de Funções");
            Console.WriteLine($"Escolha uma função:/n");
            Console.WriteLine($" 1 - Calculadora de juros simples: ");
            Console.WriteLine($" 2 - Calculadora de juros compostos: ");
            Console.WriteLine($" 3 - Calculadora de economia mensal: ");
            Console.WriteLine("Digite o número da opção desejada: ");

        }

        public void OptionOne()
        {
            Console.WriteLine("Você escolheu a Calculadora de Juros Simples.");

            Console.WriteLine("Digite o capital inicial: ");
            double initialCapital = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a taxa de juros (em decimal): ");
            double interestRate = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tempo de aplicação (em anos): ");
            double aplicationTime = double.Parse(Console.ReadLine());
            CalculatorService calculatorService = new CalculatorService();
            double amount = calculatorService.SimpleInterestCalculater(initialCapital, interestRate, aplicationTime);
            Console.WriteLine($"O montante após {aplicationTime} anos será: {amount}");

        }

        public void OptionTwo()
        {
            Console.WriteLine("Você escolheu a Calculadora de Juros Compostos.");
            Console.WriteLine("Digite o capital inicial: ");
            double initialCapital = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a taxa de juros (em decimal): ");
            double interestRate = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tempo de aplicação (em anos): ");
            double aplicationTime = double.Parse(Console.ReadLine());
            CalculatorService calculatorService = new CalculatorService();
            double amount = calculatorService.CompoundInterestCalculater(initialCapital, interestRate, aplicationTime);
            Console.WriteLine($"O montante após {aplicationTime} anos será: {amount}");
        }

        public void OptionThree()
        {
            Console.WriteLine("Você escolheu a Calculadora de Economia Mensal.");
            Console.WriteLine("Digite o valor mensal economizado: ");
            double montlhlyAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a despesa total mensal: ");
            double totalExpense = double.Parse(Console.ReadLine());
            CalculatorService calculatorService = new CalculatorService();
            double economiaMensal = calculatorService.EconomiaMensalCalculater(montlhlyAmount, totalExpense);
            Console.WriteLine($"A economia mensal é: {economiaMensal}");
        }
    }
}
