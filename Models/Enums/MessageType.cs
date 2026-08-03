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
public sealed record MessageType : StringEnum<MessageType>
{
    private MessageType(string value) : base(value)
    {
    }

    public static readonly MessageType Request = new("Request");

    public static readonly MessageType Response = new("Response");

    public static readonly MessageType Notification = new("Notification");

    public static MessageType FromValue(string value) => FromValueCore(value);
}
