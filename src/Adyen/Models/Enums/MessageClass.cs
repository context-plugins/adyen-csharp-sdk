using System;
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
public sealed record MessageClass : OpenStringEnum<MessageClass>
{
    private MessageClass(string value) : base(value)
    {
    }

    public static readonly MessageClass Service = new("Service");

    public static readonly MessageClass Device = new("Device");

    public static readonly MessageClass Event = new("Event");

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
