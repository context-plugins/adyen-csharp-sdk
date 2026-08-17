using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the balance account, set to <b>active</b> by default.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status23>))]
public sealed record Status23 : StringEnum<Status23>
{
    private Status23(string value) : base(value)
    {
    }

    public static readonly Status23 Active = new("active");

    public static readonly Status23 Closed = new("closed");

    public static readonly Status23 Inactive = new("inactive");

    public static readonly Status23 Suspended = new("suspended");

    public static Status23 FromValue(string value) => FromValueCore(value);
}
