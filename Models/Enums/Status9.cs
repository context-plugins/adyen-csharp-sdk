using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the network token. Possible values: <b>active</b>, <b>inactive</b>, <b>suspended</b>, <b>closed</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status9>))]
public sealed record Status9 : StringEnum<Status9>
{
    private Status9(string value) : base(value)
    {
    }

    public static readonly Status9 Active = new("active");

    public static readonly Status9 Inactive = new("inactive");

    public static readonly Status9 Suspended = new("suspended");

    public static readonly Status9 Closed = new("closed");

    public static Status9 FromValue(string value) => FromValueCore(value);
}
