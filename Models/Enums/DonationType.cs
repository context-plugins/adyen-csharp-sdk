using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DonationType>))]
public sealed record DonationType : StringEnum<DonationType>
{
    private DonationType(string value) : base(value)
    {
    }

    public static readonly DonationType Roundup = new("roundup");

    public static readonly DonationType FixedAmounts = new("fixedAmounts");

    public static readonly DonationType FixedAmountsRoundup = new("fixedAmountsRoundup");

    public static DonationType FromValue(string value) => FromValueCore(value);
}
