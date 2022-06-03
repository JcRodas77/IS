using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Calculadora
{
    class Codigo
    {
        static void Main(string[] args)
        {
            Console.Writeline("Ingrese numero");
            int primer = int.Parse(Console.ReadLine());
            Console.Writeline("Ingrese numero");
            int segundo = int.Parse(Console.ReadLine());
            int resultado;
            string signo;
            signo = Console.ReadLine();
            switch (signo)
            {
                case "+"
                {
                    resultado = (primer + segundo);
                    Console.Writeline(("El resultado es:  "+resultado),Console.ForegroundColor = ConsoleColor.Green);
                    break;

                }
                case "-"
                {
                    resultado = (primer - segundo);
                    Console.Writeline(("El resultado es:  "+resultado),Console.ForegroundColor = ConsoleColor.Green);
                    break;
                }

                
                default:
                {
                    break;

                }
            }
            Console.Readkey();

        }
    }
}