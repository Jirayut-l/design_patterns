using System;

namespace design_patterns
{
    class Program
    {
        private static readonly IClient Client = new Client(new ConcreteFactory1(), new ConcreteFactory2());

        static void Main(string[] args)
        {
            Client.Main();
        }
    }
}
