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
[JsonConverter(typeof(StringEnumConverter<Status9>))]
public sealed record Status9 : StringEnum<Status9>
{
    private Status9(string value) : base(value)
    {
    }

    public static readonly Status9 Active = new("active");

    public static readonly Status9 Closed = new("closed");

    public static readonly Status9 Suspended = new("suspended");

    public static Status9 FromValue(string value) => FromValueCore(value);
}
