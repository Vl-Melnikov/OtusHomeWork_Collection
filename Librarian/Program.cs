using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Librarian
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ConcurrentDictionary<string, int> dict = new ConcurrentDictionary<string, int>();

            Task.Run(() =>
            {
                while (true)
                {
                    foreach (var item in dict)
                    {
                        var percent = item.Value + 1;
                        dict.TryUpdate(item.Key, percent, item.Value);
                        Thread.Sleep(1000);

                        if (percent == 100)
                        {
                            dict.TryRemove(item.Key, out percent);
                        }
                    }
                }
            });

            while (true)
            {
                Console.WriteLine("1 - Добавить книгу; \n2 - Вывести список непрочитанного; \n3 - Выйти;");
                var action = int.TryParse(Console.ReadLine(), out var result);

                if (action == true)
                {
                    if (result == 1)
                    {
                        Console.WriteLine("Введите название книги:");
                        var bookName = Console.ReadLine();
                        var obj = dict.Where(item => item.Key == bookName).FirstOrDefault();
                        if (obj.Key == null)
                        {
                            Task.Run(() =>
                            {
                                dict.TryAdd(bookName, 0);
                            });
                        }
                    }
                    if (result == 2)
                    {
                        foreach (var item in dict)
                        {
                            Console.WriteLine($"{item.Key} - {item.Value}%");
                        }
                    }
                    if (result == 3)
                    {
                        break;
                    }
                }
            }
        }
    }
}