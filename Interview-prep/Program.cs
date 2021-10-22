using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    class Program
    {
        public void FizzBuzz()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i.ToString() + " FizzBuzz");
                }
                else
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i.ToString() + " is Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine(i.ToString() + " is Buzz");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.FizzBuzz();
        }
    }
}
