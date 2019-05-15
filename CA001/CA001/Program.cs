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
            var smallests = GetSmallests(list, 3);            

            Console.WriteLine("Small Number : {0}", small);

            foreach (var number in smallests)
            {
                Console.WriteLine("Small Number : {0}", number);
            }


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

        public static List<int> GetSmallests(List<int> list, int count)
        {
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = GetSmallest(list);
                smallests.Add(min);
                list.Remove(min);
            }
            return smallests;
        }
    }
}
