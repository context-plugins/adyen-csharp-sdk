using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the webhook setting. Possible values:
/// <list type="bullet">
///   <item><description><b>active</b>: You receive a balance webhook if any of the conditions in this setting are met.</description></item>
///   <item><description><b>inactive</b>: You do not receive a balance webhook even if the conditions in this settings are met.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status19>))]
public sealed record Status19 : StringEnum<Status19>
{
    private Status19(string value) : base(value)
    {
    }

    public static readonly Status19 Active = new("active");

    public static readonly Status19 Inactive = new("inactive");

    public static Status19 FromValue(string value) => FromValueCore(value);
}
