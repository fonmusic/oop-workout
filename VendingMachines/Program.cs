using VendingMachines.Models;
using VendingMachines.Services;

var vendingMachine = new VendingMachine();

var coinDispenser = vendingMachine.CoinDispenser;
coinDispenser.AddCoins(new Coin(1), 10);
coinDispenser.AddCoins(new Coin(0.5m), 20);
coinDispenser.AddCoins(new Coin(0.25m), 30);

var mars = new Product("Mars", 1.5m, new Place(1, ProductType.Food));
vendingMachine.LoadProduct(mars);

var cocaCola = new Bottle("Coca-Cola", 2.0m, 500, new Place(1, ProductType.Drink));
vendingMachine.LoadProduct(cocaCola);

var coffee = new HotDrink("Coffee", 1.0m, 80, new Place(2, ProductType.HotDrink));
vendingMachine.LoadProduct(coffee);
Console.WriteLine(vendingMachine);

var insertedAmount = 2.0m;

Console.WriteLine(vendingMachine.BuyProduct(mars, insertedAmount)
    ? $"Purchase successful! Get your {mars}!"
    : "Purchase failed. Not enough money or change unavailable.");

Console.WriteLine($"Total sales: ${vendingMachine.TotalSales}");

Console.WriteLine(vendingMachine);

insertedAmount = 3.0m;

Console.WriteLine(vendingMachine.BuyProduct(cocaCola, insertedAmount)
    ? $"Purchase successful! Get your {cocaCola}!"
    : "Purchase failed. Not enough money or change unavailable.");

Console.WriteLine($"Total sales: ${vendingMachine.TotalSales}");

Console.WriteLine(vendingMachine);