using System;

namespace PreworkCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Calculator");

            Console.WriteLine("What would you like to do? ( +, -, *, / )");

            string control;
            control = Console.ReadLine();

            Console.WriteLine("Please Input Valid Two Numerical Values");

            string numericOne;
            string numericTwo;
            numericOne = Console.ReadLine();
            numericTwo = Console.ReadLine();

            int resultsOne;
            int resultsTwo;

            Int32.TryParse(numericOne, out resultsOne);
            Int32.TryParse(numericTwo, out resultsTwo);

            if (control == "+")
            {
                int store;
                store = Add(resultsOne, resultsTwo);
                Console.WriteLine($"Results are {store}");
            }

            if (control == "-")
            {
                int store;
                store = Sub(resultsOne, resultsTwo);
                Console.WriteLine($"Results are {store}");
            }

            if (control == "*")
            {
                int store;
                store = Multi(resultsOne, resultsTwo);
                Console.WriteLine($"Results are {store}");
            }

            if (control == "/")
            {
                int store;
                store = Div(resultsOne, resultsTwo);
                Console.WriteLine($"Results are {store}");
            }
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();

        } // end of main

        private static int Add(int one, int two)
        {
            return one + two;
        }

        private static int Sub(int one, int two)
        {
            return one - two;
        }

        private static int Multi(int one, int two)
        {
            return one * two;
        }

        private static int Div(int one, int two)
        {
            return two / one;
        }

    } // Outside of class
}
