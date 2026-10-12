namespace Adyen.Requests.RecurringApi;

/// <summary>
/// The inputs of the DeleteStoredPaymentMethodsStoredPaymentMethodId operation.
/// </summary>
public sealed record DeleteStoredPaymentMethodsStoredPaymentMethodIdRequest
{
    /// <summary>
    /// The unique identifier of the token.
    /// </summary>
    public required string StoredPaymentMethodId { get; init; }

    /// <summary>
    /// Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters.
    /// &gt; Your reference must not include personally identifiable information (PII), for example name or email address.
    /// </summary>
    public required string ShopperReference { get; init; }

    /// <summary>
    /// Your merchant account.
    /// </summary>
    public required string MerchantAccount { get; init; }
}
