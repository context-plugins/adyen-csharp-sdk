using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of recurring contract to be used.
/// Possible values:
/// * <c>ONECLICK</c> – Payment details can be used to initiate a one-click payment, where the shopper enters the <see href="https://docs.adyen.com/payments-fundamentals/payment-glossary#card-security-code-cvc-cvv-cid">card security code (CVC/CVV)</see>.
/// * <c>RECURRING</c> – Payment details can be used without the card security code to initiate <see href="https://docs.adyen.com/payments-fundamentals/payment-glossary#card-not-present-cnp">card-not-present transactions</see>.
/// * <c>ONECLICK,RECURRING</c> – Payment details can be used regardless of whether the shopper is on your site or not.
/// * <c>PAYOUT</c> – Payment details can be used to <see href="https://docs.adyen.com/online-payments/online-payouts">make a payout</see>.
/// * <c>EXTERNAL</c> - Use this when you store payment details and send the raw card number or network token directly in your API request.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Contract>))]
public sealed record Contract : StringEnum<Contract>
{
    private Contract(string value) : base(value)
    {
    }

    public static readonly Contract Oneclick = new("ONECLICK");

    public static readonly Contract OneclickRecurring = new("ONECLICK,RECURRING");

    public static readonly Contract Recurring = new("RECURRING");

    public static readonly Contract Payout = new("PAYOUT");

    public static readonly Contract External = new("EXTERNAL");

    public static Contract FromValue(string value) => FromValueCore(value);
}
