
using System;
using System.Collections;

namespace ArrayListClass
{
    class Product
    {
        string name;
        double cost;
        int onhand;
        public Product(string n, double c, int h)
        {
            name = n;
            cost = c;
            onhand = h;
        }
        public override string ToString()
        {
            return String.Format("{0,-10}Cost: {1,6:C} On hand: {2}", name, cost, onhand);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList inv = new ArrayList();

            inv.Add(new Product("A", 5.9, 3));
            inv.Add(new Product("B", 1.8, 8));

            foreach (Product item in inv)
            {
                Console.WriteLine(" " + item);
            }
        }
    }
}
