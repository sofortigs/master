using System;
using System.Collections.Generic;

namespace Shop
{
    class Program
    {
        static Shop shop = new Shop(15, 10, 7);
        static void Main(string[] args)
        {
            Queue<Buyer> buyers = new Queue<Buyer>();
            int countDays = 1; ;
            while (countDays < 5)
            {
                Console.WriteLine("-----DAY " + countDays + "-----");
                Console.WriteLine("-----BUYER 1-----");
                buyers.Enqueue(new Buyer(ListOfProduct(), 200));
                shop.NextBuyer(buyers.Dequeue());
                Console.WriteLine(" ");
                Console.WriteLine("-----BUYER 2-----");
                buyers.Enqueue(new Buyer(ListOfProduct(), 100));
                shop.NextBuyer(buyers.Dequeue());
                countDays++;
                shop.ExpDateCount();
                Console.WriteLine("============================================");
            }

            static List<Products> ListOfProduct()
            {
                List<Products> list = new List<Products>();
                Random random = new Random();
                int countOfMilk = random.Next(0, 4);
                for(int i=0; i< countOfMilk; i++)
                {
                    
                    list.Add(new Milk());
                }
                int countOfBread = random.Next(0, 4);
                for (int i = 0; i < countOfBread; i++)
                {
                    list.Add(new Bread());
                }
                int countOfCake = random.Next(0, 4);
                for (int i = 0; i < countOfCake; i++)
                {
                    list.Add(new Cake());
                }
                return list;
            }
        }
    }
}
