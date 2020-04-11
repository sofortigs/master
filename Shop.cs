using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public class Shop
    {
        
        public Queue<Milk> milk = new Queue<Milk>();
        public Queue<Bread> bread = new Queue<Bread>();
        public Queue<Cake> cake = new Queue<Cake>();

        public Shop(int milkCount, int cakeCount, int breadCount)
        {
            for (int i = 0; i < milkCount; i++)
            {
                milk.Enqueue(new Milk());
            }
            for (int i = 0; i < breadCount; i++)
            {
                bread.Enqueue(new Bread());
            }
            for (int i = 0; i < cakeCount; i++)
            {
                cake.Enqueue(new Cake());
            }
        }
        public void NextBuyer(Buyer buyer)
        {
            int totalPrice = 0;
            int milkCount = 0;
            int breadCount = 0;
            int cakeCount = 0;
            foreach (Products item in buyer._productsList)
            {
                if (item is Milk)
                {
                    milkCount++;
                    if (milk.Count != 0)
                    {
                        milk.Dequeue();
                        totalPrice += ((Milk)item).price;
                    }
                    else
                    {
                        Console.WriteLine("milk is no more");
                        continue;
                    }
                }
                if (item is Cake)
                {
                    cakeCount++;
                    if (cake.Count != 0)
                    {
                        cake.Dequeue();
                        totalPrice += ((Cake)item).price;
                    }
                    else
                    {
                        Console.WriteLine("Cake is no more!");
                        continue;
                    }
                }
                if(item is Bread)
                {
                    breadCount++;
                    if (bread.Count != 0)
                    {
                        bread.Dequeue();
                        totalPrice += ((Bread)item).price;
                    }
                    else
                    {
                        Console.WriteLine("Bread is no more!");
                        continue;
                    }
                }
            }
            Console.WriteLine("Milk - "+ milkCount);
            Console.WriteLine("Bread - " + breadCount);
            Console.WriteLine("Cake - " + cakeCount);
            Console.WriteLine("Total price: "+totalPrice);

            if (totalPrice > buyer._cash)
            {
                Console.WriteLine("You have not enough money, go home!");
                foreach (Products item in buyer._productsList)
                {
                    if (item is Milk)
                    {
                        milk.Enqueue(new Milk());
                        continue;                 
                    }
                    if (item is Cake)
                    { 
                            cake.Enqueue(new Cake());
                            continue;
                    }
                    
                    if (item is Bread)
                    {
                            bread.Enqueue(new Bread());
                            continue;    
                    }
                }
            }
            else
            {
                buyer._cash -= totalPrice;
                Console.WriteLine("You got " + buyer._cash + "$ left");
            }
        }
    }
}
