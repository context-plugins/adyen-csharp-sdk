using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of token replacing the PAN of a payment card to identify the payment mean of the customer. It allows, for a merchant, to use a token for a transaction only or for a longer period.
/// Possible values:
/// * <b>Transaction</b>
/// * <b>Customer</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TokenRequestedType>))]
public sealed record TokenRequestedType : OpenStringEnum<TokenRequestedType>
{
    private TokenRequestedType(string value) : base(value)
    {
    }

    public static readonly TokenRequestedType Transaction = new("Transaction");

    public static readonly TokenRequestedType Customer = new("Customer");

    public TResult Match<TResult>(Func<TResult> onTransaction,
        Func<TResult> onCustomer,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Transaction => onTransaction(),
            _ when this == Customer => onCustomer(),
            _ => otherwise(Value)
        };

    public void Match(Action onTransaction, Action onCustomer, Action<string> otherwise)
    {
        if (this == Transaction) onTransaction();
        else if (this == Customer) onCustomer();
        else otherwise(Value);
    }
}
