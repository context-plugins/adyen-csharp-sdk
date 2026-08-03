using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of your request. This will always have the value <b>received</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status20>))]
public sealed record Status20 : StringEnum<Status20>
{
    private Status20(string value) : base(value)
    {
    }

    public static readonly Status20 Received = new("received");

    public static Status20 FromValue(string value) => FromValueCore(value);
}
