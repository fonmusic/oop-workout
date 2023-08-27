using VendingMachines.Models;
using VendingMachines.Services;

var vendingMachine = new VendingMachine();

var coinDispenser = vendingMachine.CoinDispenser;
coinDispenser.AddCoins(new Coin(1), 10);
coinDispenser.AddCoins(new Coin(0.5m), 20);
coinDispenser.AddCoins(new Coin(0.25m), 30);

var snikers = new Product("Snikers", 1.5m);
var snikersPlace = new Place(1, 1);
vendingMachine.LoadProduct(snikersPlace, snikers);

var cocacola = new Bottle("Coca-Cola", 2.0m, 500);
var cocacolaPlace = new Place(1, 2);
vendingMachine.LoadProduct(cocacolaPlace, cocacola);

var coffee = new HotDrink("Coffee", 1.0m, 80);
var coffeePlace = new Place(2, 1);
vendingMachine.LoadProduct(coffeePlace, coffee);
Console.WriteLine(vendingMachine);

var insertedAmount = 2.0m;

Console.WriteLine(vendingMachine.BuyProduct(snikersPlace, insertedAmount)
    ? "Purchase successful!"
    : "Purchase failed. Not enough money or change unavailable.");

Console.WriteLine($"Total sales: ${vendingMachine.CalculateTotalSales()}");
