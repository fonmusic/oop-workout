using SuperMarket.Interfaces;

namespace SuperMarket.Classes;

public class TaxInspector : IActorBehaviour
{
    private string Name { get; set; } = "Tax auditor";
    public bool TookOrder { get; set; }
    public bool MadeOrder { get; set; }

    public Actor GetActor()
    {
        return new OrdinaryClient(Name);
    }
}