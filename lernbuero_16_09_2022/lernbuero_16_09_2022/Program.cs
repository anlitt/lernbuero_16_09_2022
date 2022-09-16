using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lernbuero_16_09_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int zahl = Convert.ToInt16(Console.ReadLine());
                switch (zahl)
                //funktioniert mit strings und ints 
                //ist wie if und else
                {
                    case 1:
                    //if
                        Console.WriteLine("Die Zahl ist 1");
                        break;
                    case 2:
                    //if else
                        Console.WriteLine("Die Zahl ist 2");
                        break ;
                    case 5:
                    //if else
                        Console.WriteLine("Die Zahl ist 5");
                        break;
                    default:
                    //else
                        Console.WriteLine("Kein Fall tritt ein");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
