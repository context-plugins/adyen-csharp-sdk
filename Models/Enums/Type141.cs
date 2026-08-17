using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The <see href="https://docs.adyen.com/issuing/transaction-rules#rule-types">type of rule</see>, which defines if a rule blocks transactions based on individual characteristics or accumulates data.
/// <para>
/// Possible values:
///  * <b>blockList</b>: decline a transaction when the conditions are met.
///  * <b>maxUsage</b>: add the amount or number of transactions for the lifetime of a payment instrument, and then decline a transaction when the specified limits are met.
///  * <b>velocity</b>: add the amount or number of transactions based on a specified time interval, and then decline a transaction when the specified limits are met.
///  * <b>bypass</b>: bypass or skip a rule for the specified <c>entityKey</c>. Transactions processed to that entity are no longer evaluated by the bypassed rule.  You must provide the <c>id</c> of the rule to bypass in <c>overridesRule</c> and leave the <c>ruleRestrictions</c> object empty.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type141>))]
public sealed record Type141 : StringEnum<Type141>
{
    private Type141(string value) : base(value)
    {
    }

    public static readonly Type141 AllowList = new("allowList");

    public static readonly Type141 BlockList = new("blockList");

    public static readonly Type141 Bypass = new("bypass");

    public static readonly Type141 MaxUsage = new("maxUsage");

    public static readonly Type141 Velocity = new("velocity");

    public static Type141 FromValue(string value) => FromValueCore(value);
}
