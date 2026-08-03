using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the PIN delivery.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status7>))]
public sealed record Status7 : StringEnum<Status7>
{
    private Status7(string value) : base(value)
    {
    }

    public static readonly Status7 Created = new("created");

    public static readonly Status7 Delivered = new("delivered");

    public static readonly Status7 NotApplicable = new("notApplicable");

    public static readonly Status7 Processing = new("processing");

    public static readonly Status7 Produced = new("produced");

    public static readonly Status7 Rejected = new("rejected");

    public static readonly Status7 Shipped = new("shipped");

    public static readonly Status7 Unknown = new("unknown");

    public static Status7 FromValue(string value) => FromValueCore(value);
}
