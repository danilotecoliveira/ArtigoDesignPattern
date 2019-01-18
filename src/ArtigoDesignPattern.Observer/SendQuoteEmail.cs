using System;
using ArtigoDesignPattern.Observer.Interfaces;

namespace ArtigoDesignPattern.Observer
{
    public class SendQuoteEmail : IObserver
    {
        private decimal _dollar;
        private decimal _euro;
        private decimal _pound;

        public SendQuoteEmail(ISubject subject)
        {
            subject.RegisterObserver(this);
        }

        public void Update(decimal dollar, decimal euro, decimal pound)
        {
            _dollar = dollar;
            _euro = euro;
            _pound = pound;

            SendEmail();
        }

        public void SendEmail()
        {
            Console.WriteLine($"Este observer envia as informações por e-mail");

            // SMTP IMPLEMENTATION
        }
    }
}
