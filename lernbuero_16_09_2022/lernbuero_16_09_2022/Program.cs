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
                //sagt wieder das 13 plätze im string array sind 
                string[] namen = new string[13];
                //sagt welche namen drin sind und weist dementspreechend viele plätze zu
                string[] namen2 = new string[] {"lukas", "jonas", "mona", "marie", "philip","jan",
                "erwin", "leon" ,"marcello", "robin", "johannes", "andreas",
                "robert"
                };
                
                for(int i = 0; i < namen2.Length; i++)
                {
                    namen2[i] += " 123";
                    Console.WriteLine(namen2[i]);
                }
                
                /*foreach(string trainee in namen2)
                {
                    //kann Trainee nicht als Michael funktionieren; ist technisch nicht möglich
                    trainee = "Michael";
                    Console.WriteLine(trainee);
                }*/
               
                Console.ReadLine();

            }
        }
    }
}
