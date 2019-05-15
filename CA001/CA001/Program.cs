using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA001
{
    class Program
    {
        static void Main(string[] args)
        {
            // hi
            List<int> list = new List<int> {1 ,2 ,3 ,4 ,5};
            var small = GetSmallest(list);
            Console.WriteLine("Small Number : {0}", small);
            Console.ReadLine();
        }
        public static int GetSmallest(List<int> list)
        {
            var min = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }
}
