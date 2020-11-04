using System;

namespace Task2
{
    class Converter
    {
        public string currencyIn, currencyOut;
        readonly double exchangeRate;

        public Converter(string currencyIn, double exchangeRate, string currencyOut)
        {
            this.currencyIn = currencyIn;
            this.currencyOut = currencyOut;
            this.exchangeRate = exchangeRate;
        }
        public void ToUAH(double amount)
        {
            Console.WriteLine($"{amount * exchangeRate} {currencyOut}");
        }
        public void ToCurrency(double amount)
        {
            Console.WriteLine($"{amount / exchangeRate} {currencyIn}");
        }
    }
}
