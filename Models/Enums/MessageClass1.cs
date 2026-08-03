using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Class of the message.
/// Possible values:
/// * <b>Device</b>
/// * <b>Event</b>
/// * <b>Service</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MessageClass1>))]
public sealed record MessageClass1 : StringEnum<MessageClass1>
{
    private MessageClass1(string value) : base(value)
    {
    }

    public static readonly MessageClass1 Service = new("Service");

    public static readonly MessageClass1 Device = new("Device");

    public static readonly MessageClass1 Event = new("Event");

    public static MessageClass1 FromValue(string value) => FromValueCore(value);
}
