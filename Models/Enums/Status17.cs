using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the store. Possible values are:
/// <list type="bullet">
///   <item><description><b>active</b>. This value is assigned automatically when a store is created.</description></item>
///   <item><description><b>inactive</b>. The terminals under the store are blocked from accepting new transactions, but capturing outstanding transactions is still possible.</description></item>
///   <item><description><b>closed</b>. This status is irreversible. The terminals under the store are reassigned to the merchant inventory.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status17>))]
public sealed record Status17 : StringEnum<Status17>
{
    private Status17(string value) : base(value)
    {
    }

    public static readonly Status17 Active = new("active");

    public static readonly Status17 Closed = new("closed");

    public static readonly Status17 Inactive = new("inactive");

    public static Status17 FromValue(string value) => FromValueCore(value);
}
