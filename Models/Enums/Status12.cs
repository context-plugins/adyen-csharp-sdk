using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the account holder.
/// &gt;Permitted values: <c>Active</c>, <c>Inactive</c>, <c>Suspended</c>, <c>Closed</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status12>))]
public sealed record Status12 : StringEnum<Status12>
{
    private Status12(string value) : base(value)
    {
    }

    public static readonly Status12 Active = new("Active");

    public static readonly Status12 Closed = new("Closed");

    public static readonly Status12 Inactive = new("Inactive");

    public static readonly Status12 Suspended = new("Suspended");

    public static Status12 FromValue(string value) => FromValueCore(value);
}
