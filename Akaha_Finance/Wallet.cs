using System;

namespace Akaha_Finance
{
    internal class Wallet
    {
        private decimal myMoney;

        public decimal Money
        {
            get { return myMoney; }
            set 
            { 
                myMoney = value; 
            }
        }

        public void ShowMyFinance()
        {
            Console.WriteLine($"Денег: {Money}");
            Console.Write("Нажмите любую кнопку");
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
