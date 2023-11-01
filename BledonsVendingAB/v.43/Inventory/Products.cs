using System;
using System.Collections.Generic;

namespace v._43.Inventory
{
    public abstract class Products
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }



        public Products(string id, string name, int price, int quantity)
        {
            ID = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }


    }
    class Drink : Products
    {
        public Drink(string id, string name, int price, int quantity) : base(id, name, price, quantity)
        {
        }
    }
    class Healty : Products
    {
        public Healty(string id, string name, int price, int quantity) : base(id, name, price, quantity)
        {
        }
    }
    class Snack : Products
    {
        public Snack(string id, string name, int price, int quantity) : base(id, name, price, quantity)
        {
        }
    }

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
    class Fill
    {
        static void Refill(Stock stock)
        {


            
            Drink drink2 = new Drink("Drink", "Redbull", 30, 5);
            Drink drink3 = new Drink("Drink", "Water", 10, 5);

            stock.AddStock(new Drink("Drink", "Coca Cola", 22, 5));
            stock.AddStock(drink2);             // tobias tips o tricks neråt spara plats. 
            stock.AddStock(drink3);  

            stock.AddStock(new Healty("Healthy", "Apple Slices", 15, 5));
            stock.AddStock(new Healty("Healthy", "Tiny Carrots", 15, 5));
            stock.AddStock(new Healty("Healthy", "Golden Duck Egg", 1000, 5)); // Ger evigt liv. 

            stock.AddStock(new Snack("Snack", "Kex Choklad", 20, 5)); //  citat från flickvännen "alla bra Vendingmashines måste ha Kex Choklad "
            stock.AddStock(new Snack("Snack", "Sport Lunch", 26, 5));
            stock.AddStock(new Snack("Snack", "Choklad Boll ", 15, 5));

            List<Products> productList = stock.GetProducts();
            foreach (Products product in productList)
            {
                Console.WriteLine($"ID: {product.ID}, Name: {product.Name}, Price: ${product.Price}, Quantity: {product.Quantity}");
            }

            Console.ReadLine();

        }




    }
}

