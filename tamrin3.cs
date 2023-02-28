using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                float x;
                Console.WriteLine(" Please enter your score , to check your status !! ");
                x = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine(" your score from 20 is " + x);
                Console.WriteLine(" -------------------------------- ");
                Console.WriteLine(" your score from 100 is " + x * 5);
                Console.WriteLine(" -------------------------------- ");

                if (17 < x && x <= 20)
                {
                    Console.WriteLine(" WELL-DONE , Your score is RANK A ");
                    Console.WriteLine(" -------------------------------- ");
                }

                if (15 < x && x <= 17)
                {
                    Console.WriteLine(" Good , Your score is RANK B ");
                    Console.WriteLine(" -------------------------------- ");
                }

                if (10 < x && x <= 15)
                {
                    Console.WriteLine(" Your score is RANK C ");
                    Console.WriteLine(" -------------------------------- ");
                }

                if (0 < x && x <= 10)
                {
                    Console.WriteLine(" REJECTED , next term see you :) ");
                    Console.WriteLine(" -------------------------------- ");
                }
                String user_input2;
                Console.WriteLine("  do you wnat continue y/n ?! ");
                user_input2 = Console.ReadLine();
                if (user_input2.ToLower() == "y")
                {
                    continue;
                }
                else if(user_input2.ToLower() == "n")
                {
                    Console.WriteLine("god-by , ended");
                    break;
                }
            }
        }
    }
}
