using VendingMachines.Models;
using VendingMachines.Services;


Console.WriteLine("Welcome to Vending Machine app!");
Console.WriteLine("At this stage you are an owner of the machine.");
Console.Write("Please, enter the number of places in the machine: ");
var numberOfPlaces = int.Parse(Console.ReadLine() ?? string.Empty);
Console.Write("Please, enter the capacity of each place: ");
var capacity = int.Parse(Console.ReadLine() ?? string.Empty);
var vendingMachine = new VendingMachine(numberOfPlaces, capacity);
Console.WriteLine("Please, enter the number of coins of each type you want to load:");
Console.Write("1$: ");
var oneDollar = int.Parse(Console.ReadLine() ?? string.Empty);
Console.Write("0.5$: ");
var fiftyCents = int.Parse(Console.ReadLine() ?? string.Empty);
Console.Write("0.25$: ");
var twentyFiveCents = int.Parse(Console.ReadLine() ?? string.Empty);
vendingMachine.AddCoins(new Coin(1), oneDollar);
vendingMachine.AddCoins(new Coin(0.5m), fiftyCents);
vendingMachine.AddCoins(new Coin(0.25m), twentyFiveCents);
Console.Write("Please, enter the number of products you want to load: ");
var numberOfProducts = int.Parse(Console.ReadLine() ?? string.Empty);
var productList = new List<Product>();
for (var i = 0; i < numberOfProducts; i++)
{
    Console.Write("Please, enter the name of the product: ");
    var name = Console.ReadLine();
    Console.Write("Please, enter the price of the product: ");
    var price = decimal.Parse(Console.ReadLine() ?? string.Empty);
    Console.Write("Please, enter the type of the product (Bottle (1), HotDrink (2) or Snack (3)): ");
    var type = Console.ReadLine();
    switch (type)
    {
        case "1":
            Console.Write("Please, enter the volume of the bottle: ");
            var volume = double.Parse(Console.ReadLine() ?? string.Empty);
            productList.Add(new Bottle(name, price, volume));
            break;
        case "2":
            Console.Write("Please, enter the temperature of the drink: ");
            var temperature = int.Parse(Console.ReadLine() ?? string.Empty);
            productList.Add(new HotDrink(name, price, temperature));
            break;
        case "3":
            productList.Add(new Product(name, price));
            break;
    }
}

vendingMachine.LoadProduct(productList);
Console.WriteLine(vendingMachine);
Console.WriteLine("Now you are a customer of the machine.");
while (true)
{
    Console.WriteLine("If you want to buy a product, please, enter 1.");
    Console.WriteLine("If you want to quit, please, enter 2.");
    var input = Console.ReadLine();
    switch (input)
    {
        case "1":
        {
            Console.WriteLine("Please, insert money.");
            Console.Write("Please, enter the amount of money you want to insert: ");
            var inputMoney = decimal.Parse(Console.ReadLine() ?? string.Empty);
            vendingMachine.InsertMoney(inputMoney);
            Console.WriteLine("Please, choose a product.");
            Console.Write("Please, enter the number of the place: ");
            var placeId = int.Parse(Console.ReadLine() ?? string.Empty);
            vendingMachine.BuyProduct(placeId);
            Console.WriteLine(vendingMachine);
            break;
        }
        case "2":
            Console.WriteLine("Thank you for using our Vending Machine app!");
            return;
    }
}



