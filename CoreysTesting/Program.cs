using System;
using System.Collections.Generic;
using CoreysKnickKnacks;

namespace CoreysTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's add some products please enter \"id,name,price\", enter \"done\" when you've entered all products");
            List<Product> products = new List<Product>();

            while(true)
            {
                var input = Console.ReadLine();
                if (input == "done") break;

                var parts = input.Split(",");
                Product p = new Product();
                p.SetId(int.Parse(parts[0]));
                p.SetName(parts[1]);
                p.SetPrice(decimal.Parse(parts[2]));
                products.Add(p);
            }

            Console.WriteLine("Add items to your cart with \"id,quantity\" - type \"purchase\" when ready to buy");

            List<ShoppingCartItem> itemsInCart = new List<ShoppingCartItem>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "purchase") break;

                var parts = input.Split(",");
                var id = int.Parse(parts[0]);
                var product = products.Find((p) => p.GetId() == id);
                ShoppingCartItem item = new ShoppingCartItem(product, int.Parse(parts[1]));

                itemsInCart.Add(item);
            }

            var grandTotal = 0M;
            foreach(ShoppingCartItem cartItem in itemsInCart)
            {
                Console.WriteLine(cartItem.GetProduct().GetName() + "\t\t" + cartItem.GetQuantity() + "\t\t" + cartItem.GetTotal());
                grandTotal += cartItem.GetTotal();
            }

            Console.WriteLine("Grand Total: \t\t\t\t " + grandTotal);
        }
    }
}
