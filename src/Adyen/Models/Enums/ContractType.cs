using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The contract type of the grant offer. Possible value: <b>cashAdvance</b>, <b>loan</b>., The contract type of the offer.
/// <para>
/// Possible values:
/// * <b>loan</b>
/// * <b>cashAdvance</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ContractType>))]
public sealed record ContractType : OpenStringEnum<ContractType>
{
    private ContractType(string value) : base(value)
    {
    }

    public static readonly ContractType CashAdvance = new("cashAdvance");

    public static readonly ContractType Loan = new("loan");

    public TResult Match<TResult>(Func<TResult> onCashAdvance, Func<TResult> onLoan, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CashAdvance => onCashAdvance(),
            _ when this == Loan => onLoan(),
            _ => otherwise(Value)
        };

    public void Match(Action onCashAdvance, Action onLoan, Action<string> otherwise)
    {
        if (this == CashAdvance) onCashAdvance();
        else if (this == Loan) onLoan();
        else otherwise(Value);
    }
}
