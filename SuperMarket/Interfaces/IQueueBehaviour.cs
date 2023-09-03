namespace SuperMarket.Interfaces;

public interface IQueueBehaviour
{
    void TakeInQueue(IActorBehaviour actor);
    void ReleaseFromQueue();
    void TakeOrder();
    void GiveOrder();
}