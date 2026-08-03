using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the balance account, set to <b>active</b> by default.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status21>))]
public sealed record Status21 : StringEnum<Status21>
{
    private Status21(string value) : base(value)
    {
    }

    public static readonly Status21 Active = new("active");

    public static readonly Status21 Closed = new("closed");

    public static readonly Status21 Inactive = new("inactive");

    public static readonly Status21 Suspended = new("suspended");

    public static Status21 FromValue(string value) => FromValueCore(value);
}
