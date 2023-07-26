using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIZZBAZZ
{
    class Program
    {
        static void Main(string[] args)
        {
                // Defina o valor máximo (N) para o qual deseja executar o FizzBuzz
                int N = 55;

                for (int i = 1; i <= N; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                           Console.ReadLine();
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                         Console.ReadLine();
                }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                         Console.ReadLine();
                }
                    else
                    {
                        Console.WriteLine(i);
                        Console.ReadLine();
                }
                }
            }
        }

    
}

