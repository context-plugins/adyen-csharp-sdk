using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicator for the length of time since this delivery address was first used.
/// Allowed values:
/// * thisTransaction
/// * lessThan30Days
/// * from30To60Days
/// * moreThan60Days
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DeliveryAddressUsageIndicator>))]
public sealed record DeliveryAddressUsageIndicator : StringEnum<DeliveryAddressUsageIndicator>
{
    private DeliveryAddressUsageIndicator(string value) : base(value)
    {
    }

    public static readonly DeliveryAddressUsageIndicator ThisTransaction = new("thisTransaction");

    public static readonly DeliveryAddressUsageIndicator LessThan30Days = new("lessThan30Days");

    public static readonly DeliveryAddressUsageIndicator From30To60Days = new("from30To60Days");

    public static readonly DeliveryAddressUsageIndicator MoreThan60Days = new("moreThan60Days");

    public static DeliveryAddressUsageIndicator FromValue(string value) => FromValueCore(value);
}
