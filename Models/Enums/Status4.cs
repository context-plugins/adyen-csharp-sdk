using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the account.
/// &gt;Permitted values: <c>Active</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status4>))]
public sealed record Status4 : StringEnum<Status4>
{
    private Status4(string value) : base(value)
    {
    }

    public static readonly Status4 Active = new("Active");

    public static readonly Status4 Closed = new("Closed");

    public static readonly Status4 Inactive = new("Inactive");

    public static readonly Status4 Suspended = new("Suspended");

    public static Status4 FromValue(string value) => FromValueCore(value);
}
