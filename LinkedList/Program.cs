using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            int command = 0;
            while (command != 7)
            {
                Console.WriteLine("1. Добавление");
                Console.WriteLine("2. Удаление");
                Console.WriteLine("3. Проверить содержание списка на наличие");
                Console.WriteLine("4. Добавить элемент в начало списка");
                Console.WriteLine("5. Очистить лист");
                Console.WriteLine("6. Вывести лист");
                Console.WriteLine("7. Exit");
                command = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (command)
                {
                    case 1:
                        Console.Write("Напиши добавляемое число:");
                        list.Add(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("Напиши удаляемое число:");
                        list.Remove(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write("Напиши число которое хочешь проверить:");
                        Console.WriteLine(list.Contains(Convert.ToInt32(Console.ReadLine())));
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.Write("Напиши число для добавления в начало списка:");
                        list.AppendFirst(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine();
                        break;
                    case 5:
                        list.Clear();
                        break;
                    case 6:
                        Console.Write("Список:");
                        foreach (var item in list)
                        {
                            Console.Write($"{item} ");
                            
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Invalid command. Please enter a number between 1 and 7.");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }

}
