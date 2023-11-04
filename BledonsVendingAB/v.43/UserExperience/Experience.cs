using System;
namespace v._43.UserExperience
{
	public class Experience
	{ 
		public Experience()
		{

		}
		public void Meny()
		{
			while (true)
			{
				Console.WriteLine("1. See Meny");
                Console.WriteLine("2. Insert Money");
                Console.WriteLine("3. Buy Item");
                Console.WriteLine("4. Cancel");
                Console.WriteLine(" Please Select an option 1-4 ");

                string input = Console.ReadLine();

				switch (input)
				{
					case "1":
						ShowAll();
						break;
							case "2":
						InsertMoney();
						break;
							case "3":
						BuyItem();
						break;
							case "4":
						Cancel();
							break;//= cancel = retun money and go back to meny()

					default:
						Console.WriteLine(" Please select one of the options");
						break;
				}
			}
		}
	}
}

