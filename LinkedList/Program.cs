using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    public class Item<T>
    {
        public Item(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Item<T> Next { get; set; }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {

            
        }
    }
}
