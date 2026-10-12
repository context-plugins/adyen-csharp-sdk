using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>Request</b>
/// * <b>Response</b>
/// * <b>Notification</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MessageType>))]
public sealed record MessageType : OpenStringEnum<MessageType>
{
    private MessageType(string value) : base(value)
    {
    }

    public static readonly MessageType Request = new("Request");

    public static readonly MessageType Response = new("Response");

    public static readonly MessageType Notification = new("Notification");

    public TResult Match<TResult>(Func<TResult> onRequest,
        Func<TResult> onResponse,
        Func<TResult> onNotification,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Request => onRequest(),
            _ when this == Response => onResponse(),
            _ when this == Notification => onNotification(),
            _ => otherwise(Value)
        };

    public void Match(Action onRequest, Action onResponse, Action onNotification, Action<string> otherwise)
    {
        if (this == Request) onRequest();
        else if (this == Response) onResponse();
        else if (this == Notification) onNotification();
        else otherwise(Value);
    }
}
