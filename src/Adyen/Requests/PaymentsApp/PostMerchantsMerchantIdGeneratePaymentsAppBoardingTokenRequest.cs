using System.ComponentModel.DataAnnotations;
using Adyen.Models;

namespace Adyen.Requests.PaymentsApp;

/// <summary>
/// The inputs of the PostMerchantsMerchantIdGeneratePaymentsAppBoardingToken operation.
/// </summary>
public sealed record PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    [MinLength(1)]
    public required string MerchantId { get; init; }

    public required BoardingTokenRequest Body { get; init; }
}
