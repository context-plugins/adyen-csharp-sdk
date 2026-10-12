namespace Adyen.Requests.RecurringApi;

/// <summary>
/// The inputs of the GetStoredPaymentMethods operation.
/// </summary>
public sealed record GetStoredPaymentMethodsRequest
{
    /// <summary>
    /// Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters.
    /// &gt; Your reference must not include personally identifiable information (PII), for example name or email address.
    /// </summary>
    public string? ShopperReference { get; init; }

    /// <summary>
    /// Your merchant account.
    /// </summary>
    public string? MerchantAccount { get; init; }
}
