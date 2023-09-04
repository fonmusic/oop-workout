namespace SuperMarket.Models;

public interface IActorBehaviour
{
    bool TookOrder { get; set; }
    bool MadeOrder { get; set; }
    Actor GetActor();
}