using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);
            numbers.Enqueue(4);

            Console.WriteLine("Все элементы:");
            foreach (int item in numbers)
                Console.WriteLine(item);
            Console.WriteLine();

            Console.WriteLine();
            int firstItem = numbers.Dequeue();
            Console.WriteLine("Первый элемент: " + firstItem);
            
            int secondItem = numbers.Dequeue();
            Console.WriteLine("Второй элемент: " + secondItem);
            Console.WriteLine();

            Console.WriteLine("Оставшиеся элементы:");
            foreach (int item in numbers)
                Console.WriteLine(item);
            Console.WriteLine();

            Console.WriteLine("Первый элемент из оставшихся без извлечения:");
            int fitem = numbers.Peek();
            Console.WriteLine(fitem);


            Console.ReadKey();
        }
    }

        
    }

