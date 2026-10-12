using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The tax reporting classification type.
/// <para>
/// Possible values: <b>nonFinancialNonReportable</b>, <b>financialNonReportable</b>, <b>nonFinancialActive</b>, <b>nonFinancialPassive</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type151>))]
public sealed record Type151 : OpenStringEnum<Type151>
{
    private Type151(string value) : base(value)
    {
    }

    public static readonly Type151 NonFinancialNonReportable = new("nonFinancialNonReportable");

    public static readonly Type151 FinancialNonReportable = new("financialNonReportable");

    public static readonly Type151 NonFinancialActive = new("nonFinancialActive");

    public static readonly Type151 NonFinancialPassive = new("nonFinancialPassive");

    public TResult Match<TResult>(Func<TResult> onNonFinancialNonReportable,
        Func<TResult> onFinancialNonReportable,
        Func<TResult> onNonFinancialActive,
        Func<TResult> onNonFinancialPassive,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NonFinancialNonReportable => onNonFinancialNonReportable(),
            _ when this == FinancialNonReportable => onFinancialNonReportable(),
            _ when this == NonFinancialActive => onNonFinancialActive(),
            _ when this == NonFinancialPassive => onNonFinancialPassive(),
            _ => otherwise(Value)
        };

    public void Match(Action onNonFinancialNonReportable,
        Action onFinancialNonReportable,
        Action onNonFinancialActive,
        Action onNonFinancialPassive,
        Action<string> otherwise)
    {
        if (this == NonFinancialNonReportable) onNonFinancialNonReportable();
        else if (this == FinancialNonReportable) onFinancialNonReportable();
        else if (this == NonFinancialActive) onNonFinancialActive();
        else if (this == NonFinancialPassive) onNonFinancialPassive();
        else otherwise(Value);
    }
}
