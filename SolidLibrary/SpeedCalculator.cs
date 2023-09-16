namespace SolidLibrary;

public class SpeedCalculator
{
    public double CalculateAllowedSpeed(Vehicle vehicle)
    {
        return vehicle.CalculateAllowedSpeed();
    }
}

public class Vehicle
{
    protected readonly int MaxSpeed;
    protected string Type;

    protected Vehicle(int maxSpeed, string type)
    {
        MaxSpeed = maxSpeed;
        Type = type;
    }

    public virtual double CalculateAllowedSpeed()
    {
        return 0.0;
    }
}

public class Car : Vehicle
{
    public Car(int maxSpeed, string type) : base(maxSpeed, type)
    {
    }

    public override double CalculateAllowedSpeed()
    {
        return MaxSpeed * 0.8;
    }
}

public class Bus : Vehicle
{
    public Bus(int maxSpeed, string type) : base(maxSpeed, type)
    {
    }

    public override double CalculateAllowedSpeed()
    {
        return MaxSpeed * 0.6;
    }
}