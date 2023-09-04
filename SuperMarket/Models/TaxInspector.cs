namespace SuperMarket.Models;

public class TaxInspector :  IActorBehaviour
{
    private string Name { get; set; } = "Tax Inspector";
    public bool TookOrder { get; set; }
    public bool MadeOrder { get; set; }

    public Actor GetActor()
    {
        return new OrdinaryClient(Name);
    }
}