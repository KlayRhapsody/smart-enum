
using SmartEnum;

var creditCard = CreditCard.Platinum;


Console.WriteLine($"Credit card: {creditCard}, discount: {creditCard.Discount:P}");
Console.ReadKey();