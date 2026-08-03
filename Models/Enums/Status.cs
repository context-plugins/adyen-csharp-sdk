using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the store. Possible values: <b>Pending</b>, <b>Active</b>, <b>Inactive</b>, <b>InactiveWithModifications</b>, <b>Closed</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status>))]
public sealed record Status : StringEnum<Status>
{
    private Status(string value) : base(value)
    {
    }

    public static readonly Status Active = new("Active");

    public static readonly Status Closed = new("Closed");

    public static readonly Status Inactive = new("Inactive");

    public static readonly Status InactiveWithModifications = new("InactiveWithModifications");

    public static readonly Status Pending = new("Pending");

    public static Status FromValue(string value) => FromValueCore(value);
}
