using SuperMarket.Classes;

namespace SuperMarket.Interfaces;

public interface IActorBehaviour
{
    bool TookOrder { get; set; }
    bool MadeOrder { get; set; }
    Actor GetActor();
}