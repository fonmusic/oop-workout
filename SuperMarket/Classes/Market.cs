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
        ReturnOrderAndMoney();
        ReleaseFromQueue();
    }

    private void ReturnOrderAndMoney()
    {
        foreach (var actor in _queue)
        {
            if (actor.GetActor() is not IReturnOrder returnOrderClient) continue;
            returnOrderClient.ReturnOrder();
            returnOrderClient.MoneyReturn();
        }
    }

    public void TakeInQueue(IActorBehaviour actor)
    {
        _queue.Add(actor);
        Console.WriteLine(actor is TaxInspector
            ? $"{actor.GetActor().Name} started checking documents"
            : $"{actor.GetActor().Name} took a place in the queue");
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
            switch (actor)
            {
                case TaxInspector:
                    break;
                case PromotionalClient promotionalClient:
                    Console.WriteLine($"{actor.GetActor().Name} took the order for {promotionalClient.PromotionName}");
                    break;
                default:
                    Console.WriteLine($"{actor.GetActor().Name} took the order");
                    break;
            }
        }
    }

    public void GiveOrder()
    {
        foreach (var actor in _queue.Where(actor => actor.GetActor().TookOrder && !actor.GetActor().MadeOrder))
        {
            actor.GetActor().MadeOrder = true;
            switch (actor)
            {
                case PromotionalClient promotionalClient:
                    Console.WriteLine($"{actor.GetActor().Name} gave the order: {promotionalClient.PromotionName}");
                    break;
                default:
                    Console.WriteLine($"{actor.GetActor().Name} gave the order");
                    break;
            }
        }
    }
}