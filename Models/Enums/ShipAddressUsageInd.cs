using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates when the shipping address used for this transaction was first used with the 3DS Requestor.
/// Allowed values:
/// * <b>01</b> — This transaction
/// * <b>02</b> — Less than 30 days
/// * <b>03</b> — 30–60 days
/// * <b>04</b> — More than 60 days
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ShipAddressUsageInd>))]
public sealed record ShipAddressUsageInd : StringEnum<ShipAddressUsageInd>
{
    private ShipAddressUsageInd(string value) : base(value)
    {
    }

    public static readonly ShipAddressUsageInd _01 = new("01");

    public static readonly ShipAddressUsageInd _02 = new("02");

    public static readonly ShipAddressUsageInd _03 = new("03");

    public static readonly ShipAddressUsageInd _04 = new("04");

    public static ShipAddressUsageInd FromValue(string value) => FromValueCore(value);
}
