using System;
using ArtigoDesignPattern.Observer.Interfaces;

namespace ArtigoDesignPattern.Observer
{
    public class Trader1 : IObserver
    {
        private decimal _dollar;
        private decimal _euro;
        private decimal _pound;

        public Trader1(ISubject subject)
        {
            subject.RegisterObserver(this);
        }

        public void Update(decimal dollar, decimal euro, decimal pound)
        {
            _dollar = dollar;
            _euro = euro;
            _pound = pound;

            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Cotação atual Dolar: R${_dollar}, Euro R${_euro} e Libra: R${_pound}");
        }
    }
}
