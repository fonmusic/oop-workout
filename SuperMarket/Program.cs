using SuperMarket.Classes;
using SuperMarket.Interfaces;

var market = new Market();

IActorBehaviour client1 = new OrdinaryClient("Ivan Petrov");
IActorBehaviour client2 = new SpecialClient("James Bond", 777);
IActorBehaviour client3 = new TaxInspector();
IActorBehaviour client4 = new PromotionalClient("Maria", "Milk");
IActorBehaviour client5 = new PromotionalClient("Alex", "Bread");
IActorBehaviour client6 = new PromotionalClient("Peter", "Beer");
IActorBehaviour client7 = new SpecialClient("Elizabet", 2);

var numberOfPromotionalParticipants = PromotionalClient.NumberOfPromotionalParticipants;
Console.WriteLine($"Number of promotional participants: {numberOfPromotionalParticipants}");

market.AcceptToMarket(client1);
market.AcceptToMarket(client2);
market.AcceptToMarket(client3);
market.AcceptToMarket(client4);
market.AcceptToMarket(client5);
market.AcceptToMarket(client6);
market.AcceptToMarket(client7);

market.Update();