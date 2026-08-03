using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PayoutMethod
{
    /// <summary>
    /// The <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__reqParam_merchantAccount"><c>merchantAccount</c></see> you used in the <c>/payments</c> request when you <see href="https://docs.adyen.com/classic-platforms/payouts/manual-payout/payout-to-cards#check-and-store">saved the account holder's card details</see>.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// Adyen-generated unique alphanumeric identifier (UUID) for the payout method, returned in the response when you create a payout method. Required when updating an existing payout method in an <c>/updateAccountHolder</c> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutMethodCode")]
    public string? PayoutMethodCode { get; init; }

    /// <summary>
    /// Your reference for the payout method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutMethodReference")]
    public string? PayoutMethodReference { get; init; }

    /// <summary>
    /// The <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_additionalData-ResponseAdditionalDataCommon-recurring-recurringDetailReference"><c>recurringDetailReference</c></see>  returned in the <c>/payments</c> response when you <see href="https://docs.adyen.com/classic-platforms/payouts/manual-payout/payout-to-cards#check-and-store">saved the account holder's card details</see>.
    /// </summary>
    [JsonPropertyName("recurringDetailReference")]
    public required string RecurringDetailReference { get; init; }

    /// <summary>
    /// The <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__reqParam_shopperReference"><c>shopperReference</c></see> you sent in the <c>/payments</c> request when you <see href="https://docs.adyen.com/classic-platforms/payouts/manual-payout/payout-to-cards#check-and-store">saved the account holder's card details</see>.
    /// </summary>
    [JsonPropertyName("shopperReference")]
    public required string ShopperReference { get; init; }
}
