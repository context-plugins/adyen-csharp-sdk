namespace Adyen.Requests.UsersMerchantLevel;

/// <summary>
/// The inputs of the GetMerchantsMerchantIdUsersUserId operation.
/// </summary>
public sealed record GetMerchantsMerchantIdUsersUserIdRequest
{
    /// <summary>
    /// Unique identifier of the merchant.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// Unique identifier of the user.
    /// </summary>
    public required string UserId { get; init; }
}
