using System;
namespace v._43.Inventory
{
    public class Stock
    {
        public List<Products> products;

        public Stock()
        {
            products = new List<Products>();
        }

        public void AddStock(Products product)
        {
            products.Add(product);
        }

        public List<Products> GetProducts()
        {
            return products;
        }

    }
    public class Fill
    {
        public static void Refill(Stock stock)
        {



            Drink drink2 = new Drink(1, "Redbull", 30, 5);
            Drink drink3 = new Drink(2 , "Water", 10, 5);

            stock.AddStock(new Drink(3, "Coca Cola", 22, 5));
            stock.AddStock(drink2);             // tobias tips o tricks neråt spara plats. 
            stock.AddStock(drink3);

            stock.AddStock(new Healty(4, "Apple Slices", 15, 5));
            stock.AddStock(new Healty(4, "Tiny Carrots", 15, 5));
            stock.AddStock(new Healty(5, "Golden Duck Egg", 1000, 5)); // Ger evigt liv. 

            stock.AddStock(new Snack(6, "Kex Choklad", 20, 5)); //  citat från Fia-  "alla bra Vendingmashines måste ha Kex Choklad "
            stock.AddStock(new Snack(7, "Sport Lunch", 26, 5));
            stock.AddStock(new Snack(8, "Choklad Boll ", 15, 5));

            List<Products> productList = stock.GetProducts();
            foreach (Products product in productList)
            {
                Console.WriteLine($"ID: {product.ID}, Name: {product.Name}, Price: ${product.Price}, Quantity: {product.Quantity}");
                
            }

            Console.ReadLine();

        }
    }

}