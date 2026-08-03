using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the recurring top-up. If not provided, by default, this is set to <b>active</b>.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>active</b>:  the top up is enabled and funds will be pulled in.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>inactive</b>: the top up is disabled and cannot be triggered.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status211>))]
public sealed record Status211 : StringEnum<Status211>
{
    private Status211(string value) : base(value)
    {
    }

    public static readonly Status211 Active = new("active");

    public static readonly Status211 Inactive = new("inactive");

    public static Status211 FromValue(string value) => FromValueCore(value);
}
