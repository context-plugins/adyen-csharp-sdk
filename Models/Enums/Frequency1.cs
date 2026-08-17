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
[JsonConverter(typeof(StringEnumConverter<Frequency1>))]
public sealed record Frequency1 : StringEnum<Frequency1>
{
    private Frequency1(string value) : base(value)
    {
    }

    public static readonly Frequency1 Daily = new("daily");

    public static readonly Frequency1 Weekly = new("weekly");

    public static readonly Frequency1 Weekdays = new("weekdays");

    public static readonly Frequency1 Monthly = new("monthly");

    public static Frequency1 FromValue(string value) => FromValueCore(value);
}
