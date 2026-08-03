using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The capability level that is allowed for the account holder.
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
