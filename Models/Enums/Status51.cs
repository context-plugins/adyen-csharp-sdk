using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the sweep. If not provided, by default, this is set to <b>active</b>.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>active</b>:  the sweep is enabled and funds will be pulled in or pushed out based on the defined configuration.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>inactive</b>: the sweep is disabled and cannot be triggered.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status51>))]
public sealed record Status51 : StringEnum<Status51>
{
    private Status51(string value) : base(value)
    {
    }

    public static readonly Status51 Active = new("active");

    public static readonly Status51 Inactive = new("inactive");

    public static Status51 FromValue(string value) => FromValueCore(value);
}
