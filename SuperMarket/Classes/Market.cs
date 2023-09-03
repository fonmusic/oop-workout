using SuperMarket.Interfaces;

namespace SuperMarket.Classes;

public class Market : IMarketBehaviour, IQueueBehaviour
{
    private List<IActorBehaviour> _queue = new();

    public void AcceptToMarket(IActorBehaviour actor)
    {
        Console.WriteLine($"{actor.GetActor().Name} came to the market");
        TakeInQueue(actor);
    }

    public void ReleaseFromMarket(List<Actor> actors)
    {
        foreach (var actor in actors)
        {
            Console.WriteLine($"{actor.Name} left the market");
            _queue.Remove(actor);
        }
    }

    public void Update()
    {
        TakeOrder();
        GiveOrder();
        ReleaseFromQueue();
    }

    public void TakeInQueue(IActorBehaviour actor)
    {
        _queue.Add(actor);
        Console.WriteLine($"{actor.GetActor().Name} took a place in the queue");
    }

    public void ReleaseFromQueue()
    {
        List<Actor> releaseActors = new();
        foreach (var actor in _queue.Where(actor => actor.GetActor().TookOrder))
        {
            releaseActors.Add(actor.GetActor());
            Console.WriteLine($"{actor.GetActor().Name} left the queue");
        }
        ReleaseFromMarket(releaseActors);
    }

    public void TakeOrder()
    {
        foreach (var actor in _queue.Where(actor => !actor.GetActor().TookOrder))
        {
            actor.GetActor().TookOrder = true;
            Console.WriteLine($"{actor.GetActor().Name} took the order");
        }
    }

    public void GiveOrder()
    {
        foreach (var actor in _queue.Where(actor => actor.GetActor().TookOrder && !actor.GetActor().MadeOrder))
        {
            actor.GetActor().MadeOrder = true;
            Console.WriteLine($"{actor.GetActor().Name} gave the order");
        }
    }
}