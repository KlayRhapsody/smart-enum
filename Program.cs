
using SmartEnum;

var creditCard = CreditCard.FromValue(1);


Console.WriteLine($"Credit card: {creditCard}, discount: {creditCard.Discount:P}");
Console.ReadKey();