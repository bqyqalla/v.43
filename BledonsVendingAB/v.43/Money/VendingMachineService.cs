using System;
using v._43.Inventory;

namespace v._43.Money
{
    public class VendingMachineService : IVending
    {
        readonly int[] validDenominations = { 1, 5, 10, 20, 50, 100, 500, 1000 };
        public Stock Stock = new Stock();
        public int moneyPool = 0;

        public VendingMachineService()
        {
            Fill.Refill(Stock); // add stock
        }

        public List<string> ShowAll()
        {
            List<string> productList = new List<string>();

            foreach (Products product in Stock.products)
            {
                productList.Add($" ID: {product.ID}, Name: {product.Name}, Price: {product.Price} kr,Quantity {product.Quantity}");
            }
            foreach (var product in productList )
            {
                Console.WriteLine(product);
            }
               
                    
            return productList;
        }


        public Products BuyItem(int productID)
        {
            Products product = Stock.products.Find(p => p.ID == productID);

            if (product.Quantity > 0 && moneyPool >= product.Price)
            {
                moneyPool -= product.Price;
                product.Quantity--;

                Console.WriteLine($" You just bought a {product.Name}. Balance: {moneyPool}kr");

                
            }

            else
            {
                Console.WriteLine("Unable to buy the product. Please cheack your Balance or Quantaty of the item.");
            }


            return product;
        }
        public int InsertMoney(int money)
        {

            if (Array.IndexOf(validDenominations, money) != -1)
            {
                moneyPool += money;
            }
            else
            {
                Console.WriteLine("Please Use Valid Denominations");
            }

            return money;
        }

        public Dictionary<int, int> EndTransaction()
        {
            Dictionary<int, int> change = new Dictionary<int, int>();


            foreach (int denomination in validDenominations.OrderByDescending(d => d))
            {
                int count = moneyPool;

                if (count > 0)
                {

                    change.Add(denomination, count);
                    moneyPool %= denomination * count;
                }


            }
            foreach (var kvp in change)
            {
                Console.WriteLine($"{kvp.Key} kr, {kvp.Value} Bills/Conis");


            }
            moneyPool = 0;
            return change;
        }


    }
    
}
