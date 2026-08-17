using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the network token. Possible values: <b>active</b>, <b>inactive</b>, <b>suspended</b>, <b>closed</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status91>))]
public sealed record Status91 : StringEnum<Status91>
{
    private Status91(string value) : base(value)
    {
    }

    public static readonly Status91 Active = new("active");

    public static readonly Status91 Inactive = new("inactive");

    public static readonly Status91 Suspended = new("suspended");

    public static readonly Status91 Closed = new("closed");

    public static Status91 FromValue(string value) => FromValueCore(value);
}
