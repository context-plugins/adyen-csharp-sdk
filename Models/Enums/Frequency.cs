using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The frequency with which a shopper should be charged.
/// <para>
/// Possible values: <b>adhoc</b>, <b>daily</b>, <b>weekly</b>, <b>biWeekly</b>, <b>monthly</b>, <b>quarterly</b>, <b>halfYearly</b>, <b>yearly</b>., The frequency with which a shopper should be charged.
/// </para>
/// <para>
/// Possible values: <b>daily</b>, <b>weekly</b>, <b>biWeekly</b>, <b>monthly</b>, <b>quarterly</b>, <b>halfYearly</b>, <b>yearly</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Frequency>))]
public sealed record Frequency : StringEnum<Frequency>
{
    private Frequency(string value) : base(value)
    {
    }

    public static readonly Frequency Adhoc = new("adhoc");

    public static readonly Frequency Daily = new("daily");

    public static readonly Frequency Weekly = new("weekly");

    public static readonly Frequency BiWeekly = new("biWeekly");

    public static readonly Frequency Monthly = new("monthly");

    public static readonly Frequency Quarterly = new("quarterly");

    public static readonly Frequency HalfYearly = new("halfYearly");

    public static readonly Frequency Yearly = new("yearly");

    public static Frequency FromValue(string value) => FromValueCore(value);
}
