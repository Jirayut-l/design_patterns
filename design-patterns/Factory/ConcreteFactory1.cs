namespace design_patterns
{
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IProductA CreateProductA() => new ConcreteProductA1();

        public IProductB CreateProductB() => new ConcreteProductB1();

    }
}