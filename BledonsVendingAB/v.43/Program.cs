// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Xml.Linq;
using v._43.Inventory;
using v._43.Money;
using v._43.UserExperience;
//Console.WriteLine("Hello, World!");

//Drink drink = new Drink("Drink","redbull",30,5);
//drink.Examine();

//Console.WriteLine();
//Drink drink2 = new Drink("Drink", "coccola", 30, 5);
//drink2.Examine();


//Stock stock = new Stock();
//List<Products> products = new List<Products>().ToList();
//products.Add(drink);
//stock.products = products;


//Fill.Refill(stock);



Experience userExperience = new Experience();
VendingMachineService vendingMachine = new VendingMachineService();

userExperience.Meny();

