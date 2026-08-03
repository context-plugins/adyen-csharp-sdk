using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of token replacing the PAN of a payment card to identify the payment
///  mean of the customer. It allows, for a merchant, to use a token for a transaction
///  only or for a longer period.
/// Possible values:
/// * <b>Customer</b>
/// * <b>Transaction</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TokenRequestedType1>))]
public sealed record TokenRequestedType1 : StringEnum<TokenRequestedType1>
{
    private TokenRequestedType1(string value) : base(value)
    {
    }

    public static readonly TokenRequestedType1 Transaction = new("Transaction");

    public static readonly TokenRequestedType1 Customer = new("Customer");

    public static TokenRequestedType1 FromValue(string value) => FromValueCore(value);
}
