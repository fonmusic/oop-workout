using SuperMarket.Classes;

namespace SuperMarket.Interfaces;

public interface IMarketBehaviour
{
    void AcceptToMarket(IActorBehaviour actor);
    void ReleaseFromMarket(List<Actor> actors);
    void Update();
}