using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Deducts the refund costs from the specified balance account.
/// <para>
/// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RefundCostAllocation>))]
public sealed record RefundCostAllocation : OpenStringEnum<RefundCostAllocation>
{
    private RefundCostAllocation(string value) : base(value)
    {
    }

    public static readonly RefundCostAllocation DeductFromLiableAccount = new("deductFromLiableAccount");

    public static readonly RefundCostAllocation DeductFromOneBalanceAccount = new("deductFromOneBalanceAccount");

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
