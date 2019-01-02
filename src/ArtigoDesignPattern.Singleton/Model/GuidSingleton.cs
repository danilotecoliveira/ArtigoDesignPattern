using System;

namespace ArtigoDesignPattern.Singleton.Model
{
    public class GuidSingleton
    {
        private static Guid instance;

        private GuidSingleton() { }

        public static Guid Instance
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
