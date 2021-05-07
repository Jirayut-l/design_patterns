using System;

namespace design_patterns
{
    public class Client : IClient
    {
        private readonly IAbstractFactory _abstractFactory1;
        private readonly IAbstractFactory _abstractFactory2;

        public Client(IAbstractFactory abstractFactory1, IAbstractFactory abstractFactory2)
        {
            _abstractFactory1 = abstractFactory1;
            _abstractFactory2 = abstractFactory2;
        }

        public void Main()
        {
           Console.WriteLine("Client: Testing client code with the first factory type....");
            ClientMethod(_abstractFactory1);
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(_abstractFactory2);
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