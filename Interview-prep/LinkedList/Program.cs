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

        public List<int> numberList = new List<int>();
        public List<int> newNumberList = new List<int>();
        public HashSet<int> removeDupSets = new HashSet<int>();

        public void removeDuplicate()
        {
            numberList.Add(2);
            numberList.Add(3);
            numberList.Add(2);
            numberList.Add(5);
            numberList.Add(7);
            numberList.Sort();

            removeDupSets = numberList.ToHashSet();
            newNumberList = removeDupSets.ToList();

            foreach (var item in newNumberList)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            //program.FizzBuzz();
            program.removeDuplicate();
        }
    }
}
