using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the account holder.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>active</b>: The account holder is active and allowed to use its capabilities. This is the initial status for account holders and balance accounts. You can change this status to <b>suspended</b> or <b>closed</b>.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>suspended</b>: The account holder is temporarily disabled and payouts are blocked. You can change this status to <b>active</b> or <b>closed</b>.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>closed</b>: The account holder and all of its capabilities are permanently disabled. This is a final status and cannot be changed.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status5>))]
public sealed record Status5 : StringEnum<Status5>
{
    private Status5(string value) : base(value)
    {
    }

    public static readonly Status5 Active = new("active");

    public static readonly Status5 Closed = new("closed");

    public static readonly Status5 Suspended = new("suspended");

    public static Status5 FromValue(string value) => FromValueCore(value);
}
