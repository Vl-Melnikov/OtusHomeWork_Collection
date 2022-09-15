using System;

namespace RegularCustomer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var shop = new Shop();
            var customer = new Customer("Покупатель");
            customer.OnItemChanged(shop);
            int n = 0;

            while (true)
            {
                Console.WriteLine("A - добавить товар, D - удалить товар, X - выйти");
                var action = Console.ReadLine();

                if (action == "A")
                {
                    var item = new Item
                    {
                        Name = $"Товар от {DateTime.Now}",
                        Id = n + 1
                    };
                    n++;

                    shop.Add(item);
                }

                if (action == "D")
                {
                    Console.WriteLine("Какой товар удалить?");
                    int actionRemove = int.Parse(Console.ReadLine());

                    foreach (var items in shop.Items)
                    {
                        if (items.Id == actionRemove)
                        {
                            shop.Remove(items);
                            break;
                        }
                    }
                }
                if (action == "X")
                {
                    break;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Нажмите клавишу для выхода...");
            Console.ReadKey();
        }
    }
}