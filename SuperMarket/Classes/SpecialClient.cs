using SuperMarket.Interfaces;

namespace SuperMarket.Classes;

public class SpecialClient : Actor, IReturnOrder
{
    public sealed override string Name { get; set; }
    public int IdVip { get; set; }

    public SpecialClient(string name, int idVip) : base(name)
    {
        Name = $"{name} {idVip}";
        IdVip = idVip;
    }

    public void ReturnOrder()
    {
        Console.WriteLine($"Client {Name} returned order because he is VIP");
    }

    public void MoneyReturn()
    {
        Console.WriteLine($"Client {Name} returned money because he is VIP");
    }
}