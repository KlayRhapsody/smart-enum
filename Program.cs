
using SmartEnum;

var creditCard = CreditCard.FromValue(1);
var premium = CreditCard.FromName("Premium");


Console.WriteLine($"Credit card: {creditCard}, discount: {creditCard.Discount:P}");
Console.WriteLine($"Credit card: {premium}, discount: {premium.Discount:P}");
Console.ReadKey();