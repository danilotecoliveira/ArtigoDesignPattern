using System;

namespace ArtigoDesignPattern.Singleton.Model
{
    public class GuidComum
    {
        private Guid instance;

        public Guid Instance
        {
            get
            {
                if (instance == Guid.Empty)
                {
                    instance = Guid.NewGuid();
                }

                return instance;
            }
        }
    }
}
