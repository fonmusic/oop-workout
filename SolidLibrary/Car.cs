namespace SolidLibrary;

public interface IEngine
{
    void Start();
}

public class PetrolEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Petrol engine started");
    }
}

public class DieselEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Diesel engine started");
    }
}

public class CarDip
{
    private readonly IEngine _engine;

    public CarDip(IEngine engine)
    {
        _engine = engine;
    }

    public void Start()
    {
        _engine.Start();
    }
}
