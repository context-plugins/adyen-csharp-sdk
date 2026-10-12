using Adyen.Models;

namespace Adyen.Requests.AccountMerchantLevel;

/// <summary>
/// The inputs of the PostMerchants operation.
/// </summary>
public sealed record PostMerchantsRequest
{
    public CreateMerchantRequest? Body { get; init; }
}
