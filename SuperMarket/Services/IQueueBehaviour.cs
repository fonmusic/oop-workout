using SuperMarket.Models;

namespace SuperMarket.Services;

public interface IQueueBehaviour
{
    void TakeInQueue(IActorBehaviour actor);
    void ReleaseFromQueue();
    void TakeOrder();
    void GiveOrder();
}