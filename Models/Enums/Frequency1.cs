using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The frequency with which a shopper should be charged.
/// <para>
/// Possible values: <b>adhoc</b>, <b>daily</b>, <b>weekly</b>, <b>biWeekly</b>, <b>monthly</b>, <b>quarterly</b>, <b>halfYearly</b>, <b>yearly</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Frequency1>))]
public sealed record Frequency1 : StringEnum<Frequency1>
{
    private Frequency1(string value) : base(value)
    {
    }

    public static readonly Frequency1 Adhoc = new("adhoc");

    public static readonly Frequency1 Daily = new("daily");

    public static readonly Frequency1 Weekly = new("weekly");

    public static readonly Frequency1 BiWeekly = new("biWeekly");

    public static readonly Frequency1 Monthly = new("monthly");

    public static readonly Frequency1 Quarterly = new("quarterly");

    public static readonly Frequency1 HalfYearly = new("halfYearly");

    public static readonly Frequency1 Yearly = new("yearly");

    public static Frequency1 FromValue(string value) => FromValueCore(value);
}
