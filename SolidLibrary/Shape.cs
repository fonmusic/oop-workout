namespace SolidLibrary;

public interface IAreaCalculatable
{
    double Area();
}

public interface IVolumeCalculatable
{
    double Volume();
}

public class Circle : IAreaCalculatable
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double Area()
    {
        return 2 * 3.14 * _radius;
    }
}

public class Cube : IAreaCalculatable, IVolumeCalculatable
{
    private readonly int _edge;

    public Cube(int edge)
    {
        _edge = edge;
    }

    public double Area()
    {
        return 6 * _edge * _edge;
    }

    public double Volume()
    {
        return _edge * _edge * _edge;
    }
}
