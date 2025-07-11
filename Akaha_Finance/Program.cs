using Akaha_Finance;
using System;

namespace AkahaFinance
{
    public class Program
    {
        public bool isEndProgram = false;
        static void Main(string[] args)
        {
            #region Fields
            Program program = new Program();
            Wallet wallet = new Wallet();


            #endregion
            program.StartProgram();

            program.UpdateProgram(wallet, program);
           
        }

        private void StartProgram()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine();

            Console.WriteLine("Это программа для учета финансов\nДобро пожаловать\n");
        }

        private void UpdateProgram(Wallet wallet, Program program)
        {
            while (isEndProgram == false)
            {
                Console.WriteLine("МЕНЮ ВЫБОРА ОПЦИИ\n");
                Console.WriteLine("1. Мои финансы;\n6. Закрыть программу.");

                Console.Write("Введите опцию: ");
                string optionInput = "";

                optionInput = Console.ReadLine();

                if (optionInput == null || optionInput == "")
                {
                    throw new EmptyString($"Опция не может быть пустой!");
                }

                switch (optionInput)
                {
                    case "1":
                        wallet.ShowMyFinance();
                        break;
                    case "6":
                        program.EndProgram();
                        break;
                }
                Console.Clear();
            }
        }

        public void EndProgram()
        {
            Console.WriteLine("\nПрограмма закрыта, до следующего визита)");
            Environment.Exit(0);
        }
    }
}