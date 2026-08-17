using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the account.
/// &gt;Permitted values: <c>Active</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status42>))]
public sealed record Status42 : StringEnum<Status42>
{
    private Status42(string value) : base(value)
    {
    }

    public static readonly Status42 Active = new("Active");

    public static readonly Status42 Closed = new("Closed");

    public static readonly Status42 Inactive = new("Inactive");

    public static readonly Status42 Suspended = new("Suspended");

    public static Status42 FromValue(string value) => FromValueCore(value);
}
