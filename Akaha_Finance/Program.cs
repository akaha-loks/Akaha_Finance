using System;

namespace AkahaFinance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Hello, World!");
            decimal MyFinance = 0;
            program.ShowMyFinance(MyFinance);
        }

        public void ShowMyFinance(decimal myFinance)
        {
            Console.WriteLine($"Мои финансы: {myFinance} сом");
        }
    }
}