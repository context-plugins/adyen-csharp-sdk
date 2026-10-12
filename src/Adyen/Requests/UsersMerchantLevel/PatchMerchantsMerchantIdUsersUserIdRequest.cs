using Adyen.Models;

namespace Adyen.Requests.UsersMerchantLevel;

/// <summary>
/// The inputs of the PatchMerchantsMerchantIdUsersUserId operation.
/// </summary>
public sealed record PatchMerchantsMerchantIdUsersUserIdRequest
{
    /// <summary>
    /// Unique identifier of the merchant.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// Unique identifier of the user.
    /// </summary>
    public required string UserId { get; init; }

    public UpdateMerchantUserRequest? Body { get; init; }
}
