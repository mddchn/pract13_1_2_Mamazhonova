using System;
using System.Collections;

namespace pract13_1_mamazhonova
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayList list = new ArrayList() { "Петров", "Алекксеев", "Кошкина", "Пенькова", "Лесков" };
                ArrayList list1 = new ArrayList() { "Иванов", "Добренко", "Дубов", "Панкратов", "Мышкин" };
                
                foreach (object p in list)
                {
                    Console.Write(p + " ");
                }
                Console.WriteLine();


                int n1 = 0;
                while(true)
                {
                    Console.WriteLine("С какого элемента вставить новую коллекцию?");
                    n1 = int.Parse(Console.ReadLine());
                    if (n1 > list.Count || n1 < 0) Console.WriteLine("n не может быть меньше 0 или больше количества элементов в списке");
                    else break;
                }
                list.InsertRange(n1, list1);

                foreach(object p in list)
                {
                    Console.Write(p + " ");
                }
                Console.WriteLine();


                int n = n1 / 2;
                int k = 0;
                while(true)
                {
                    Console.WriteLine("Введите сколько элементов хотите удалить");
                    k = int.Parse(Console.ReadLine());
                    if (k > list.Count || k < 0) Console.WriteLine("число не может быть меньше 0 или больше количества элементов в списке");
                    else break;
                }
                list.RemoveRange(n, k);
                
                foreach (object p in list)
                {
                    Console.Write(p + " ");
                }
            }
            catch
            {
                Console.WriteLine("Неверный ввод данных");
            }
            Console.ReadKey();




        }
    }
}
