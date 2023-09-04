namespace SuperMarket.Models;

public class OrdinaryClient : Actor
{
    public sealed override string Name { get; set; }

    public OrdinaryClient(string name) : base(name)
    {
        Name = name;
    }
}
