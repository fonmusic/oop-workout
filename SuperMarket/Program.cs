using SuperMarket.Classes;
using SuperMarket.Interfaces;

var magnit = new Market();

var client1 = new OrdinaryClient("Ivan Petrov");
var client2 = new SpecialClient("James Bond", 777);
var client3 = new TaxInspector();
var client4 = new PromotionalClient("Maria", "Milk");
var client5 = new PromotionalClient("Alex", "Bread");
var client6 = new PromotionalClient("Petr", "Bear");

magnit.AcceptToMarket(client1);
magnit.AcceptToMarket(client2);
magnit.AcceptToMarket(client3);
magnit.AcceptToMarket(client4);
magnit.AcceptToMarket(client5);
magnit.AcceptToMarket(client6);

magnit.Update();
var numberOfPromotionalParticipants = PromotionalClient.NumberOfPromotionalParticipants;
Console.WriteLine($"Number of promotional participants: {numberOfPromotionalParticipants}");