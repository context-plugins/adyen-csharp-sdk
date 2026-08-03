using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The new status of the network token. Possible values: <b>active</b>, <b>suspended</b>, <b>closed</b>. The <b>closed</b> status is final and cannot be changed.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status16>))]
public sealed record Status16 : StringEnum<Status16>
{
    private Status16(string value) : base(value)
    {
    }

    public static readonly Status16 Active = new("active");

    public static readonly Status16 Suspended = new("suspended");

    public static readonly Status16 Closed = new("closed");

    public static Status16 FromValue(string value) => FromValueCore(value);
}
