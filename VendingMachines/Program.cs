using VendingMachines.Models;
using VendingMachines.Services;

var vendingMachine = new VendingMachine();

var coinDispenser = vendingMachine.CoinDispenser;
coinDispenser.AddCoins(new Coin(1), 10);
coinDispenser.AddCoins(new Coin(0.5m), 20);
coinDispenser.AddCoins(new Coin(0.25m), 30);

var mars = new Product("Mars", 1.5m);
var marsPlace = new Place(1, 1);
vendingMachine.LoadProduct(marsPlace, mars);

var cocaCola = new Bottle("Coca-Cola", 2.0m, 500);
var cocaColaPlace = new Place(1, 2);
vendingMachine.LoadProduct(cocaColaPlace, cocaCola);

var coffee = new HotDrink("Coffee", 1.0m, 80);
var coffeePlace = new Place(2, 1);
vendingMachine.LoadProduct(coffeePlace, coffee);
Console.WriteLine(vendingMachine);

var insertedAmount = 2.0m;

Console.WriteLine(vendingMachine.BuyProduct(marsPlace, insertedAmount)
    ? $"Purchase successful! Get your {marsPlace}!"
    : "Purchase failed. Not enough money or change unavailable.");

Console.WriteLine($"Total sales: ${vendingMachine.TotalSales}");

Console.WriteLine(vendingMachine);

insertedAmount = 3.0m;

Console.WriteLine(vendingMachine.BuyProduct(cocaColaPlace, insertedAmount)
    ? $"Purchase successful! Get your {cocaColaPlace}!"
    : "Purchase failed. Not enough money or change unavailable.");

Console.WriteLine($"Total sales: ${vendingMachine.TotalSales}");

Console.WriteLine(vendingMachine);
    