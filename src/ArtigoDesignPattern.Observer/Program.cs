using System;

namespace ArtigoDesignPattern.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var quote = new CurrencyQuote();
            var trader1 = new Trader1(quote);
            var trader2 = new Trader2(quote);
            var sendQuoteEmail = new SendQuoteEmail(quote);

            quote.SetValues(3.74M, 4.26M, 4.74M);
            Console.WriteLine("====================================");
            quote.SetValues(3.61M, 4.17M, 4.65M);
            Console.WriteLine("====================================");
            quote.SetValues(3.58M, 4.09M, 4.44M);

            Console.ReadKey();
        }
    }
}
