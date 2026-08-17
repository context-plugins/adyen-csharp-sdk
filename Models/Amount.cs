using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The amount that needs to be captured. The <c>currency</c> must match the currency used in authorisation, the <c>value</c> must be smaller than or equal to the authorised amount., The amount to be donated.The <c>currency</c> must match the currency used in authorisation, the <c>value</c> must be smaller than or equal to the authorised amount., The base amount., The buy rate., The interbank amount., The sell rate., For prepaid or gift card purchase, the purchase amount total of prepaid or gift card(s)., If you want a <see href="https://docs.adyen.com/payment-methods/cards/bin-data-and-card-verification">BIN or card verification</see> request to use a non-zero value, assign this value to <c>additionalAmount</c> (while the amount must be still set to 0 to trigger BIN or card verification).
/// Required to be in the same currency as the <c>amount</c>., The amount information for the transaction (in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>). For <see href="https://docs.adyen.com/payment-methods/cards/bin-data-and-card-verification">BIN or card verification</see> requests, set amount to 0 (zero)., Includes the currency of the conversion and the value of the transaction.
/// &gt; This value only applies if you have implemented Dynamic Currency Conversion. For more information, <see href="https://www.adyen.help/hc/en-us/requests/new">contact Support</see>., The amount that needs to be refunded. The <c>currency</c> must match the currency used in authorisation, the <c>value</c> must be smaller than or equal to the authorised amount., The amount that needs to be captured/refunded. Required for <c>/capture</c> and <c>/refund</c>, not allowed for <c>/cancel</c>. The <c>currency</c> must match the currency used in authorisation, the <c>value</c> must be smaller than or equal to the authorised amount., The currency and value of the new total amount in minor units. For example, to increase the amount, the value is the sum of the pre-authorized amount and the additional amount., The total sum amount of one or more payments made using this permit may not exceed this amount if set., The amount of any single payment using this permit may not exceed this amount if set., The amount of the upcoming payment., The amount information for the transaction (in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>). For <see href="https://docs.adyen.com/payment-methods/cards/bin-data-and-card-verification">BIN or card verification</see> requests, set amount to 0 (zero)., Includes the currency of the conversion and the value of the transaction.
/// &gt; This value only applies if you have implemented Dynamic Currency Conversion. For more information, <see href="https://www.adyen.help/hc/en-us/requests/new">contact Support</see>., A container object for the payable amount information of the transaction., The transaction amount used as a base for the cost estimation., The estimated cost (scheme fee + interchange) in the settlement currency. If the settlement currency cannot be determined, the fee in EUR is returned., The amount information for the transaction., The balance currently on the payment method., The amount of the payment that the notification is about. Set the value in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>., The lower bound of the processing tier (i.e., an account holder must have processed at least this amount of money in order to be placed into this tier)., The upper bound of the processing tier (i.e., an account holder must have processed less than this amount of money in order to be placed into this tier)., The maximum amount that payouts are limited to. Only applies if payouts are allowed but limited., The amount of the transaction., The amount to be debited from the account holder's bank account., An object containing the currency and value of the payout.
/// If the account has multiple currencies, specify the currency to be used.
/// If the <c>bankAccountUUID</c> is provided in the request, the currency supported by the bank is used.
/// If the <c>payoutMethodCode</c> is provided in the request, the specified payout method is selected., The amount to be transferred.
/// </summary>
public record Amount
{
    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes#currency-codes">ISO currency code</see> of the amount.
    /// </summary>
    [JsonPropertyName("currency")]
    [StringLength(3, MinimumLength = 3)]
    public required string Currency { get; init; }

    /// <summary>
    /// The numeric value of the amount, in <see href="https://docs.adyen.com/development-resources/currency-codes#minor-units">minor units</see>.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; init; }
}
