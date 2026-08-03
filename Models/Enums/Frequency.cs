using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The frequency of payouts initiated by this payout schedule.
/// <para>
/// Possible values:
/// * daily
/// * weekdays
/// * weekly
/// * monthly
/// </para>
/// <para>
/// Default value: The <c>defaultFrequency</c> from the balance platform schedule that you are applying.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Frequency>))]
public sealed record Frequency : StringEnum<Frequency>
{
    private Frequency(string value) : base(value)
    {
    }

    public static readonly Frequency Daily = new("daily");

    public static readonly Frequency Weekly = new("weekly");

    public static readonly Frequency Weekdays = new("weekdays");

    public static readonly Frequency Monthly = new("monthly");

    public static Frequency FromValue(string value) => FromValueCore(value);
}
