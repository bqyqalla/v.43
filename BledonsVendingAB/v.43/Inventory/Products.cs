using System;
using System.Collections.Generic;

namespace v._43.Inventory
{
    public abstract class Products
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }



        public Products(int id, string name, int price, int quantity)
        {
            ID = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public abstract void Examine();
        public abstract void Use();
    }
   public class Drink : Products
    {

        public object MyProperty { get; set; }
        public Drink(int id, string name, int price, int quantity) : base(id, name, price, quantity)
        {
        }
        

        public override void Examine()
        {
                Console.WriteLine($"ID: {ID}, Name: {Name}, Price: ${Price}, Quantity: {Quantity}");
        }
        public override void Use()
        {
            Console.WriteLine("");
        }
    

}
    public class Healty : Products
    {

        public Healty(int id, string name, int price, int quantity) : base(id, name, price, quantity)
        {
        }
        public override void Examine()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Price: ${Price}, Quantity: {Quantity}");
        }
        public override void Use()
        {
            Console.WriteLine("Eat the stuff ");
        }
    }
   public class Snack : Products
    {
        public Snack(int id, string name, int price, int quantity) : base(id, name, price, quantity)
        {
        }
        public override void Examine()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Price: ${Price}, Quantity: {Quantity}");
        }
        public override void Use()
        {
            Console.WriteLine("");
        }


    }

    public interface IVending
    {
        Products BuyItem(string productID);
        List<string> ShowAll();
        string Details(string productName);
        int insertMoney(int amount);
        Dictionary<int, int> EndTransaction();
    }
}

