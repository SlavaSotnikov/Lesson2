using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            Converter convert = new Converter("eur", 33.7013, "uah");

            convert.ToUAH(100);
            convert.ToCurrency(100);

            Console.ReadLine();
        }
    }
}
