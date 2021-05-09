using System;

namespace design_patterns
{
    public class Client : IClient
    {
        private readonly ConcreteFactory1 _concreteFactory1;
        private readonly ConcreteFactory2 _concreteFactory2;
        public Client(ConcreteFactory1 concreteFactory1, ConcreteFactory2 concreteFactory2)
        {
            _concreteFactory1 = concreteFactory1;
            _concreteFactory2 = concreteFactory2;
        }

        public void Main()
        {
           Console.WriteLine("Client: Testing client code with the first factory type....");
            ClientMethod(_concreteFactory1);
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(_concreteFactory2);
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();
            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}