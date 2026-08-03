using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Specifies the reason for creating the rule.
/// <para>
/// Possible values:
/// * <b>fraud</b>: the rule is created to regulate fraudulent activity.
/// * <b>policy</b>: the rule is created to ensure that the transaction adheres to your business' policies. For example, if your business has policies about the Merchant Category Codes (MCCs) allowed on a transaction, you can create a rule to block transactions that have specific MCCs.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Purpose>))]
public sealed record Purpose : StringEnum<Purpose>
{
    private Purpose(string value) : base(value)
    {
    }

    public static readonly Purpose Compliance = new("compliance");

    public static readonly Purpose Fraud = new("fraud");

    public static readonly Purpose InternalPolicy = new("internalPolicy");

    public static readonly Purpose Policy = new("policy");

    public static readonly Purpose System = new("system");

    public static Purpose FromValue(string value) => FromValueCore(value);
}
