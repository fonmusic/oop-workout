using VendingMachines.Models;
using VendingMachines.Services;

var vendingMachine = new VendingMachine(3,2);

vendingMachine.AddCoins(new Coin(1), 10);
vendingMachine.AddCoins(new Coin(0.5m), 20);
vendingMachine.AddCoins(new Coin(0.25m), 30);

var mars = new Product("Mars", 1.5m);
var cocaCola = new Bottle("Coca-Cola", 2.0m, 500);
var coffee = new HotDrink("Coffee", 1.0m, 80);

vendingMachine.LoadProduct(cocaCola);
vendingMachine.LoadProduct(mars);
vendingMachine.LoadProduct(coffee);

Console.WriteLine(vendingMachine);

var inputMoney = 2.0m;
vendingMachine.InsertMoney(inputMoney);
var placeId = 2;
vendingMachine.BuyProduct(placeId);

Console.WriteLine(vendingMachine);