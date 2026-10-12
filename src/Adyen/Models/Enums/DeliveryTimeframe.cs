using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The estimated delivery time for the shopper to receive the goods.
/// Allowed values:
/// * <c>electronicDelivery</c>
/// * <c>sameDayShipping</c>
/// * <c>overnightShipping</c>
/// * <c>twoOrMoreDaysShipping</c>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DeliveryTimeframe>))]
public sealed record DeliveryTimeframe : OpenStringEnum<DeliveryTimeframe>
{
    private DeliveryTimeframe(string value) : base(value)
    {
    }

    public static readonly DeliveryTimeframe ElectronicDelivery = new("electronicDelivery");

    public static readonly DeliveryTimeframe SameDayShipping = new("sameDayShipping");

    public static readonly DeliveryTimeframe OvernightShipping = new("overnightShipping");

    public static readonly DeliveryTimeframe TwoOrMoreDaysShipping = new("twoOrMoreDaysShipping");

    public TResult Match<TResult>(Func<TResult> onElectronicDelivery,
        Func<TResult> onSameDayShipping,
        Func<TResult> onOvernightShipping,
        Func<TResult> onTwoOrMoreDaysShipping,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ElectronicDelivery => onElectronicDelivery(),
            _ when this == SameDayShipping => onSameDayShipping(),
            _ when this == OvernightShipping => onOvernightShipping(),
            _ when this == TwoOrMoreDaysShipping => onTwoOrMoreDaysShipping(),
            _ => otherwise(Value)
        };

    public void Match(Action onElectronicDelivery,
        Action onSameDayShipping,
        Action onOvernightShipping,
        Action onTwoOrMoreDaysShipping,
        Action<string> otherwise)
    {
        if (this == ElectronicDelivery) onElectronicDelivery();
        else if (this == SameDayShipping) onSameDayShipping();
        else if (this == OvernightShipping) onOvernightShipping();
        else if (this == TwoOrMoreDaysShipping) onTwoOrMoreDaysShipping();
        else otherwise(Value);
    }
}
