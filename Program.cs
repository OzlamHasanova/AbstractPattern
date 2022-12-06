namespace AbstractPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FactoryProducer factory = new();
           AbstractFactory factory1= factory.GetFactory("Circlefactory");
            IShape shape = factory1.GetShape("Circle");
            shape.draw();
          



        }
    }
}