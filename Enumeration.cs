using System.Reflection;

namespace SmartEnum;

public abstract class Enumeration<TEnum> : IEquatable<Enumeration<TEnum>>
    where TEnum : Enumeration<TEnum>
{
    public static readonly Dictionary<int, TEnum> Enumarations = CreateEnumerations();

    protected Enumeration(int value, string name)
    {
        Value = value;
        Name = name;
    }

    public int Value { get; protected init;}

    public string Name { get; protected init; } = string.Empty;

    public static TEnum? FromValue(int value)
    {
        return Enumarations.TryGetValue(value, out TEnum? enumartion)
            ? enumartion
            : default;
    }

    public static TEnum? FromName(string name)
    {
        return Enumarations.Values.SingleOrDefault(e => e.Name == name);
    }

    public bool Equals(Enumeration<TEnum>? other)
    {
        if (other is null)
            return false;

        return GetType() == other.GetType() && Value == other.Value;
    }

    public override bool Equals(object? obj)
    {
        return obj is Enumeration<TEnum> other && Equals(other);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    public override string ToString()
    {
        return Name;
    }

    private static Dictionary<int, TEnum> CreateEnumerations()
    {
        var enumrationType = typeof(TEnum);

        var fieldsForType = enumrationType
            .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
            .Where(fieldInfo => enumrationType.IsAssignableFrom(fieldInfo.FieldType))
            .Select(fieldInfo => (TEnum)fieldInfo.GetValue(default)!);

        return fieldsForType.ToDictionary(x => x.Value);
    }
}   