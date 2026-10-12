using System.ComponentModel.DataAnnotations;
using Adyen.Models;

namespace Adyen.Requests.PaymentsApp;

/// <summary>
/// The inputs of the PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingToken operation.
/// </summary>
public sealed record PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    [MinLength(1)]
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the store.
    /// </summary>
    [MinLength(1)]
    public required string StoreId { get; init; }

    public required BoardingTokenRequest Body { get; init; }
}
