using Adyen.Models;

namespace Adyen.Requests.UsersMerchantLevel;

/// <summary>
/// The inputs of the PostMerchantsMerchantIdUsers operation.
/// </summary>
public sealed record PostMerchantsMerchantIdUsersRequest
{
    /// <summary>
    /// Unique identifier of the merchant.
    /// </summary>
    public required string MerchantId { get; init; }

    public CreateMerchantUserRequest? Body { get; init; }
}
