using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of message of the Sale to POI protocol.
/// Possible values:
/// * <b>Notification</b>
/// * <b>Request</b>
/// * <b>Response</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MessageType1>))]
public sealed record MessageType1 : OpenStringEnum<MessageType1>
{
    private MessageType1(string value) : base(value)
    {
    }

    public static readonly MessageType1 Request = new("Request");

    public static readonly MessageType1 Response = new("Response");

    public static readonly MessageType1 Notification = new("Notification");

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
