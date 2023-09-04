using SuperMarket.Models;

namespace SuperMarket.Services;

public interface IMarketBehaviour
{
    void AcceptToMarket(IActorBehaviour actor);
    void ReleaseFromMarket(List<Actor> actors);
    void Update();
}