using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    class Program
    {

        
        static void Main(string[] args)
        {

            Text text = new Text();
            text.ShowMenu();
            int option = int.Parse(Console.ReadLine());

            if (option < 1 || option > 3)
            {
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção entre 1 e 3.");
                text.ShowMenu();
            }

            switch (option)
            {
                case 1:
                    text.OptionOne();
                    break;
                case 2:
                    text.OptionTwo();
                    break;
                case 3:
                    text.OptionThree();
                    break;
            }
        }
    }
}
