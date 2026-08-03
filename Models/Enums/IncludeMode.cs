using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates whether the specified <c>eventType</c> is sent to your webhook endpoint.
/// Possible values:
/// * <b>INCLUDE</b>: Send the specified <c>eventType</c>.
/// * <b>EXCLUDE</b>: Send all event types except the specified <c>eventType</c> and other event types with the <c>includeMode</c> set to <b>EXCLUDE</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IncludeMode>))]
public sealed record IncludeMode : StringEnum<IncludeMode>
{
    private IncludeMode(string value) : base(value)
    {
    }

    public static readonly IncludeMode Exclude = new("EXCLUDE");

    public static readonly IncludeMode Include = new("INCLUDE");

    public static IncludeMode FromValue(string value) => FromValueCore(value);
}
