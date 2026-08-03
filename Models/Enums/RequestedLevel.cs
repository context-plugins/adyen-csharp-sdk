using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The requested level of the capability. Some capabilities, such as those used in <see href="https://docs.adyen.com/issuing/add-capabilities#capability-levels">card issuing</see>, have different levels. Levels increase the capability, but also require additional checks and increased monitoring.
/// <para>
/// Possible values: <b>notApplicable</b>, <b>low</b>, <b>medium</b>, <b>high</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RequestedLevel>))]
public sealed record RequestedLevel : StringEnum<RequestedLevel>
{
    private RequestedLevel(string value) : base(value)
    {
    }

    public static readonly RequestedLevel High = new("high");

    public static readonly RequestedLevel Low = new("low");

    public static readonly RequestedLevel Medium = new("medium");

    public static readonly RequestedLevel NotApplicable = new("notApplicable");

    public static RequestedLevel FromValue(string value) => FromValueCore(value);
}
