namespace design_patterns
{
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IProductA CreateProductA() => new ConcreteProductA2();

        public IProductB CreateProductB() => new ConcreteProductB2();
    }
}