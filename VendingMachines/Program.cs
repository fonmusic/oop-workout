using VendingMachines.Models;
using VendingMachines.Services;

var product1 = new Product("Coca-Cola", 10);
var product2 = new Product("Snikers", 15);
var product3 = new Product("Lays", 20);

var vendingMachine = new VendingMachine(5, 5, new Dictionary<int, int>
{
    {1, 10},
    {2, 10},
    {5, 10},
    {10, 10},
    {20, 10},
    {50, 10}
});

vendingMachine.AddProduct(product1);
vendingMachine.AddProduct(product2);
vendingMachine.AddProduct(product3);


Console.WriteLine("List of products after adding:");
Console.WriteLine(vendingMachine);

Console.WriteLine($"Get product - {vendingMachine.GetProduct("Coca-Cola")}");

Console.WriteLine("List of products after getting:");
Console.WriteLine(vendingMachine);



