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
public sealed record MessageType1 : StringEnum<MessageType1>
{
    private MessageType1(string value) : base(value)
    {
    }

    public static readonly MessageType1 Request = new("Request");

    public static readonly MessageType1 Response = new("Response");

    public static readonly MessageType1 Notification = new("Notification");

    public static MessageType1 FromValue(string value) => FromValueCore(value);
}
