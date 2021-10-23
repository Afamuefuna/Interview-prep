using System;
using System.Collections.Generic;

namespace Interview_prep
{
	public class removeDuplicate
	{
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
    }
}

