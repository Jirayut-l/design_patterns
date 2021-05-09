namespace design_patterns
{
    public class ConcreteProductB2 : IProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B2.";
        }

        public string AnotherUsefulFunctionB(IProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();
            return $"The result of the collaboration with the ({result})";
        }
    }
}