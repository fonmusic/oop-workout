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
    
    /// <summary>
    /// Method for returning order
    /// It is implemented from IReturnOrder interface and prints message that client returned order
    /// </summary>
    public void ReturnOrder()
    {
        Console.WriteLine($"Client {Name} returned order because he is VIP");
    }

    /// <summary>
    /// Method for returning money
    /// It is implemented from IReturnOrder interface and prints message that client returned money
    /// </summary>
    public void MoneyReturn()
    {
        Console.WriteLine($"Client {Name} returned money because he is VIP");
    }
}