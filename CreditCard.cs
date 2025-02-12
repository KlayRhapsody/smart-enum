namespace SmartEnum;

public abstract class CreditCard : Enumeration<CreditCard>
{
    public static readonly CreditCard Standard = new StandardCreditCard();
    public static readonly CreditCard Premium = new PremiumCreditCard();
    public static readonly CreditCard Platinum = new PlatinumCreditCard();

    private CreditCard(int value, string name) : base(value, name)
    {
    }

    public abstract double Discount { get; }

    public sealed class StandardCreditCard : CreditCard
    {
        public StandardCreditCard() : base(value: 1, name: "Standard")
        {
        }

        public override double Discount => 0.01;
    }

    public sealed class PremiumCreditCard : CreditCard
    {
        public PremiumCreditCard() : base(value: 2, name: "Premium")
        {
        }

        public override double Discount => 0.05;
    }

    public sealed class PlatinumCreditCard : CreditCard
    {
        public PlatinumCreditCard() : base(value: 3, name: "Platinum")
        {
        }

        public override double Discount => 0.1;
    }
}