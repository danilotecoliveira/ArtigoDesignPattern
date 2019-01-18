using System.Collections.Generic;
using ArtigoDesignPattern.Observer.Interfaces;

namespace ArtigoDesignPattern.Observer
{
    public class CurrencyQuote : ISubject
    {
        private readonly List<IObserver> _observers;
        private decimal _dollar;
        private decimal _euro;
        private decimal _pound;

        public CurrencyQuote()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            var i = _observers.IndexOf(observer);

            if (i > -1)
            {
                _observers.RemoveAt(i);
            }
        }

        public void NotifyObservers()
        {
            foreach (var item in _observers)
            {
                item.Update(_dollar, _euro, _pound);
            }
        }

        public void Changed()
        {
            NotifyObservers();
        }

        public void SetValues(decimal dollar, decimal euro, decimal pound)
        {
            _dollar = dollar;
            _euro = euro;
            _pound = pound;

            Changed();
        }
    }
}
