using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ScheduleType>))]
public sealed record ScheduleType : StringEnum<ScheduleType>
{
    private ScheduleType(string value) : base(value)
    {
    }

    public static readonly ScheduleType Weekdays = new("weekdays");

    public static readonly ScheduleType Weekly = new("weekly");

    public static readonly ScheduleType Monthly = new("monthly");

    public static ScheduleType FromValue(string value) => FromValueCore(value);
}
