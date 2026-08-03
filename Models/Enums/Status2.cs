using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The new status of the account.
/// &gt;Permitted values: <c>Active</c>, <c>Inactive</c>, <c>Suspended</c>, <c>Closed</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status2>))]
public sealed record Status2 : StringEnum<Status2>
{
    private Status2(string value) : base(value)
    {
    }

    public static readonly Status2 Active = new("Active");

    public static readonly Status2 Closed = new("Closed");

    public static readonly Status2 Inactive = new("Inactive");

    public static readonly Status2 Suspended = new("Suspended");

    public static Status2 FromValue(string value) => FromValueCore(value);
}
