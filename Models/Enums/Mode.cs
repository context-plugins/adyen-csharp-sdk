using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates the type of front end integration. Possible values:
/// * <b>embedded</b> (default): Drop-in or Components integration
/// * <b>hosted</b>: Hosted Checkout integration
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Mode>))]
public sealed record Mode : StringEnum<Mode>
{
    private Mode(string value) : base(value)
    {
    }

    public static readonly Mode Embedded = new("embedded");

    public static readonly Mode Hosted = new("hosted");

    public static Mode FromValue(string value) => FromValueCore(value);
}
