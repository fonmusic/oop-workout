using SuperMarket.Classes;
using SuperMarket.Interfaces;

var logFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "Logs");
Directory.CreateDirectory(logFolderPath);
var logFilePath = Path.Combine(logFolderPath, "market_log.txt");

var market = new Market();

IActorBehaviour client1 = new OrdinaryClient("Ivan Petrov");
IActorBehaviour client2 = new SpecialClient("James Bond", 777);
IActorBehaviour client3 = new TaxInspector();
IActorBehaviour client4 = new PromotionalClient("Maria", "Milk");
IActorBehaviour client5 = new PromotionalClient("Alex", "Bread");
IActorBehaviour client6 = new PromotionalClient("Peter", "Beer");
IActorBehaviour client7 = new SpecialClient("Elizabet", 2);

var numberOfPromotionalParticipants = PromotionalClient.NumberOfPromotionalParticipants;
var originalConsoleOut = Console.Out;
using (var writer = new StreamWriter(logFilePath))
{
    Console.SetOut(writer);

    Console.WriteLine($"Number of promotional participants: {numberOfPromotionalParticipants}");

    market.AcceptToMarket(client1);
    market.AcceptToMarket(client2);
    market.AcceptToMarket(client3);
    market.AcceptToMarket(client4);
    market.AcceptToMarket(client5);
    market.AcceptToMarket(client6);
    market.AcceptToMarket(client7);

    market.Update();
    
    Console.SetOut(originalConsoleOut);
}

Console.WriteLine(File.ReadAllText(logFilePath));
