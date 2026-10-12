using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Deducts the chargeback costs from the specified balance account.
/// <para>
/// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ChargebackCostAllocation>))]
public sealed record ChargebackCostAllocation : OpenStringEnum<ChargebackCostAllocation>
{
    private ChargebackCostAllocation(string value) : base(value)
    {
    }

    public static readonly ChargebackCostAllocation DeductFromLiableAccount = new("deductFromLiableAccount");

    public static readonly ChargebackCostAllocation DeductFromOneBalanceAccount = new("deductFromOneBalanceAccount");

    public TResult Match<TResult>(Func<TResult> onDeductFromLiableAccount,
        Func<TResult> onDeductFromOneBalanceAccount,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DeductFromLiableAccount => onDeductFromLiableAccount(),
            _ when this == DeductFromOneBalanceAccount => onDeductFromOneBalanceAccount(),
            _ => otherwise(Value)
        };

    public void Match(Action onDeductFromLiableAccount, Action onDeductFromOneBalanceAccount, Action<string> otherwise)
    {
        if (this == DeductFromLiableAccount) onDeductFromLiableAccount();
        else if (this == DeductFromOneBalanceAccount) onDeductFromOneBalanceAccount();
        else otherwise(Value);
    }
}
