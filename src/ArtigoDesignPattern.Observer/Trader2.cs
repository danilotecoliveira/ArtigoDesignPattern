using System;
using ArtigoDesignPattern.Observer.Interfaces;

namespace ArtigoDesignPattern.Observer
{
    public class Trader2 : IObserver
    {
        private decimal _dollar;
        private decimal _euro;

        public Trader2(ISubject subject)
        {
            subject.RegisterObserver(this);
        }

        public void Update(decimal dollar, decimal euro, decimal pound)
        {
            _dollar = dollar;
            _euro = euro;

            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Cotação atual Dolar: R${_dollar} e Euro R${_euro}");
        }
    }
}
