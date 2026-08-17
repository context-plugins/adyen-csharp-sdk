using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the store. Possible values: <b>Pending</b>, <b>Active</b>, <b>Inactive</b>, <b>InactiveWithModifications</b>, <b>Closed</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status8>))]
public sealed record Status8 : StringEnum<Status8>
{
    private Status8(string value) : base(value)
    {
    }

    public static readonly Status8 Active = new("Active");

    public static readonly Status8 Closed = new("Closed");

    public static readonly Status8 Inactive = new("Inactive");

    public static readonly Status8 InactiveWithModifications = new("InactiveWithModifications");

    public static readonly Status8 Pending = new("Pending");

    public static Status8 FromValue(string value) => FromValueCore(value);
}
