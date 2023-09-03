using SuperMarket.Classes;

var magnit = new Market();

var client1 = new OrdinaryClient("Boris");
var client2 = new SpecialClient("King", 1000);
var client3 = new TaxInspector();

magnit.AcceptToMarket(client1);
magnit.AcceptToMarket(client2);
magnit.AcceptToMarket(client3);

magnit.Update();