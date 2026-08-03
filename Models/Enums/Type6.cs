using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The schedule type.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>cron</b>: push out funds based on a <c>cronExpression</c>.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>daily</b>: push out funds daily at 07:00 AM CET.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>weekly</b>: push out funds every Monday at 07:00 AM CET.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>monthly</b>: push out funds every first of the month at 07:00 AM CET.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>balance</b>: execute the sweep instantly if the <c>triggerAmount</c> is reached.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type6>))]
public sealed record Type6 : StringEnum<Type6>
{
    private Type6(string value) : base(value)
    {
    }

    public static readonly Type6 Daily = new("daily");

    public static readonly Type6 Weekly = new("weekly");

    public static readonly Type6 Monthly = new("monthly");

    public static readonly Type6 Balance = new("balance");

    public static readonly Type6 Cron = new("cron");

    public static Type6 FromValue(string value) => FromValueCore(value);
}
