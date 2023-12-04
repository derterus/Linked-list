using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            list.Add(43);
            list.Add(2);
            list.Add(31231);
            list.Add(-12);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            list.Remove(31231);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
