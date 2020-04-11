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
            buyers.Enqueue(new Buyer(ListOfProduct(), 111));
            buyers.Enqueue(new Buyer(ListOfProduct(), 50));
            buyers.Enqueue(new Buyer(ListOfProduct(), 76));

            
            while(buyers.Count!=0)
            {
                shop.NextBuyer(buyers.Dequeue());
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
