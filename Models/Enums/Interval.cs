using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The period when the rule conditions apply.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Interval>))]
public sealed record Interval : StringEnum<Interval>
{
    private Interval(string value) : base(value)
    {
    }

    public static readonly Interval Daily = new("daily");

    public static readonly Interval Monthly = new("monthly");

    public static readonly Interval Weekly = new("weekly");

    public static Interval FromValue(string value) => FromValueCore(value);
}
