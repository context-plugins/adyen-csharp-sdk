using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>Service</b>
/// * <b>Device</b>
/// * <b>Event</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MessageClass>))]
public sealed record MessageClass : StringEnum<MessageClass>
{
    private MessageClass(string value) : base(value)
    {
    }

    public static readonly MessageClass Service = new("Service");

    public static readonly MessageClass Device = new("Device");

    public static readonly MessageClass Event = new("Event");

    public static MessageClass FromValue(string value) => FromValueCore(value);
}
