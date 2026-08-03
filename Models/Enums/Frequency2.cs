using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The frequency at which the shopper will be charged.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Frequency2>))]
public sealed record Frequency2 : StringEnum<Frequency2>
{
    private Frequency2(string value) : base(value)
    {
    }

    public static readonly Frequency2 Weekly = new("weekly");

    public static readonly Frequency2 Monthly = new("monthly");

    public static readonly Frequency2 Quarterly = new("quarterly");

    public static readonly Frequency2 HalfYearly = new("half-yearly");

    public static readonly Frequency2 Yearly = new("yearly");

    public static Frequency2 FromValue(string value) => FromValueCore(value);
}
