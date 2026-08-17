using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The new status of the account.
/// &gt;Permitted values: <c>Active</c>, <c>Inactive</c>, <c>Suspended</c>, <c>Closed</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status22>))]
public sealed record Status22 : StringEnum<Status22>
{
    private Status22(string value) : base(value)
    {
    }

    public static readonly Status22 Active = new("Active");

    public static readonly Status22 Closed = new("Closed");

    public static readonly Status22 Inactive = new("Inactive");

    public static readonly Status22 Suspended = new("Suspended");

    public static Status22 FromValue(string value) => FromValueCore(value);
}
