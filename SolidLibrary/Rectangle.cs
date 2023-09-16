namespace SolidLibrary;

public interface IShape
{
    void SetWidth(int width);
    void SetHeight(int height);
    int Area();
}

public class Rectangle : IShape
{
    private int _width;
    private int _height;

    public void SetWidth(int width)
    {
        _width = width;
    }

    public void SetHeight(int height)
    {
        _height = height;
    }

    public int Area()
    {
        return _width * _height;
    }
}

public class Square : IShape
{
    private int _side;

    public void SetWidth(int width)
    {
        _side = width;
    }

    public void SetHeight(int height)
    {
        _side = height;
    }

    public int Area()
    {
        return _side * _side;
    }
}