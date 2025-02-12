
using SmartEnum;

var creditCard = CreditCard.Platinum;

var discount = creditCard switch
{
    CreditCard.Standard => 0.01,
    CreditCard.Premium => 0.05,
    CreditCard.Platinum => 0.1,
    _ => throw new ArgumentOutOfRangeException(nameof(creditCard), creditCard, null)
};

Console.WriteLine($"Credit card: {creditCard}, discount: {discount:P}");
Console.ReadKey();