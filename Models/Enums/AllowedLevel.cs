using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The capability level that is allowed for the account holder.
/// <para>
/// Possible values: <b>notApplicable</b>, <b>low</b>, <b>medium</b>, <b>high</b>., The capability level that is allowed for the legal entity.
/// </para>
/// <para>
/// Possible values: <b>notApplicable</b>, <b>low</b>, <b>medium</b>, <b>high</b>., The requested level of the capability. Some capabilities, such as those used in <see href="https://docs.adyen.com/issuing/add-capabilities#capability-levels">card issuing</see>, have different levels. Levels increase the capability, but also require additional checks and increased monitoring.
/// </para>
/// <para>
/// Possible values: <b>notApplicable</b>, <b>low</b>, <b>medium</b>, <b>high</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AllowedLevel>))]
public sealed record AllowedLevel : StringEnum<AllowedLevel>
{
    private AllowedLevel(string value) : base(value)
    {
    }

    public static readonly AllowedLevel High = new("high");

    public static readonly AllowedLevel Low = new("low");

    public static readonly AllowedLevel Medium = new("medium");

    public static readonly AllowedLevel NotApplicable = new("notApplicable");

    public static AllowedLevel FromValue(string value) => FromValueCore(value);
}
