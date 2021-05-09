namespace design_patterns
{
    public interface IProductB
    {
        string UsefulFunctionB();
        string AnotherUsefulFunctionB(IProductA collaborator);
    }
}