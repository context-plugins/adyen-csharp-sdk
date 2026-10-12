using System;
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
public sealed record MessageClass1 : OpenStringEnum<MessageClass1>
{
    private MessageClass1(string value) : base(value)
    {
    }

    public static readonly MessageClass1 Service = new("Service");

    public static readonly MessageClass1 Device = new("Device");

    public static readonly MessageClass1 Event = new("Event");

    public TResult Match<TResult>(Func<TResult> onService,
        Func<TResult> onDevice,
        Func<TResult> onEvent,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Service => onService(),
            _ when this == Device => onDevice(),
            _ when this == Event => onEvent(),
            _ => otherwise(Value)
        };

    public void Match(Action onService, Action onDevice, Action onEvent, Action<string> otherwise)
    {
        if (this == Service) onService();
        else if (this == Device) onDevice();
        else if (this == Event) onEvent();
        else otherwise(Value);
    }
}
