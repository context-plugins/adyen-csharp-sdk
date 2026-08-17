using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the PIN delivery.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status71>))]
public sealed record Status71 : StringEnum<Status71>
{
    private Status71(string value) : base(value)
    {
    }

    public static readonly Status71 Created = new("created");

    public static readonly Status71 Delivered = new("delivered");

    public static readonly Status71 NotApplicable = new("notApplicable");

    public static readonly Status71 Processing = new("processing");

    public static readonly Status71 Produced = new("produced");

    public static readonly Status71 Rejected = new("rejected");

    public static readonly Status71 Shipped = new("shipped");

    public static readonly Status71 Unknown = new("unknown");

    public static Status71 FromValue(string value) => FromValueCore(value);
}
