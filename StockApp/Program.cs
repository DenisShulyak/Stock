using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("1) Добавление товар на склад");
                Console.WriteLine("2) Удаление товара на складе");
                Console.WriteLine("3) Просмотр товаров на складе");
                Console.WriteLine("4) Выход");
                int choice = int.Parse(Console.ReadLine());
                if(choice == 1)
                {
                    Console.Clear();
                    using (var context = new StockContext())
                    {
                        //Добавление товара на склад
                        Console.WriteLine("Введите назание товара:");
                        Product product = new Product(Console.ReadLine());
                        context.Products.Add(product);
                        context.SaveChanges();
                        Console.Clear();
                        Console.WriteLine("Товар успешно добавлен");
                        Console.WriteLine("Нажмите Enter для продолжения");
                        Console.ReadLine();
                    }
                }
               else if(choice == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Товары: ");
                    using (var context = new StockContext())
                    {
                        //Удаление товара на складе
                        var products = context.Products.ToList();

                        for (int i = 0; i < products.Count; i++)
                        {
                            Console.WriteLine(products[i].Id + ") " + products[i].Name);
                        }
                        Console.WriteLine("Выберите товар для удаления: ");
                        int idProductForDelete = int.Parse(Console.ReadLine());
                       
                        context.Products.Remove(products[idProductForDelete - 1]);
                        context.SaveChanges();
                    }

                    
                }
                else if(choice == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Товары на складе: ");
                    using (var context = new StockContext())
                    {
                        //Просмотр товара на складе
                        var products = context.Products.ToList();

                        for(int i =0; i < products.Count;i++)
                        {
                            Console.WriteLine(products[i].Id + ") " + products[i].Name);
                        }
                        Console.WriteLine("Нажмите Enter для продолжения");
                        Console.ReadLine();
                    }
                }
                else if(choice == 4)
                {
                    break;
                }


            }

        }
    }
}
