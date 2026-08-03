using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the account holder.
/// &gt;Permitted values: <c>Active</c>, <c>Inactive</c>, <c>Suspended</c>, <c>Closed</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status1>))]
public sealed record Status1 : StringEnum<Status1>
{
    private Status1(string value) : base(value)
    {
    }

    public static readonly Status1 Active = new("Active");

    public static readonly Status1 Closed = new("Closed");

    public static readonly Status1 Inactive = new("Inactive");

    public static readonly Status1 Suspended = new("Suspended");

    public static Status1 FromValue(string value) => FromValueCore(value);
}
