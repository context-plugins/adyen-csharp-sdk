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
public sealed record DeliveryTimeframe : StringEnum<DeliveryTimeframe>
{
    private DeliveryTimeframe(string value) : base(value)
    {
    }

    public static readonly DeliveryTimeframe ElectronicDelivery = new("electronicDelivery");

    public static readonly DeliveryTimeframe SameDayShipping = new("sameDayShipping");

    public static readonly DeliveryTimeframe OvernightShipping = new("overnightShipping");

    public static readonly DeliveryTimeframe TwoOrMoreDaysShipping = new("twoOrMoreDaysShipping");

    public static DeliveryTimeframe FromValue(string value) => FromValueCore(value);
}
