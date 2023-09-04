namespace SuperMarket.Models;

public abstract class Actor : IActorBehaviour
{
    public abstract string Name { get; set; }
    public bool TookOrder { get; set; }
    public bool MadeOrder { get; set; }

    protected Actor(string name)
    {
        Name = name;
    }

    public Actor GetActor()
    {
        return this;
    }
}