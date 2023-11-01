using System;
namespace v._43.Money
{
	public class Input
	{
        int moneyPool = 0;
        readonly int[] validDenominations = { 1, 5, 10, 20, 50, 100, 500, 1000 };

        public Input()
		{
		}

        public void InsertMoney(int money)
        {
          
            if (Array.IndexOf(validDenominations, money) != -1)
            {
                moneyPool += money ;
            }
            else
            {
                Console.WriteLine("Please Use Valid Denominations");
            }


        }
    }
}

