using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The text shown on the payment terminal, asking the shopper for a donation.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DisplayTextField1>))]
public sealed record DisplayTextField1 : StringEnum<DisplayTextField1>
{
    private DisplayTextField1(string value) : base(value)
    {
    }

    public static readonly DisplayTextField1 CauseName = new("causeName");

    public static readonly DisplayTextField1 NonprofitName = new("nonprofitName");

    public static DisplayTextField1 FromValue(string value) => FromValueCore(value);
}
