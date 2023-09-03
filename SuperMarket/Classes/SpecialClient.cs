namespace SuperMarket.Classes;

public class SpecialClient : Actor
{
    public sealed override string Name { get; set; }
    public int IdVip { get; set; }

    public SpecialClient(string name, int idVip) : base(name)
    {
        Name = name;
        IdVip = idVip;
    }
}