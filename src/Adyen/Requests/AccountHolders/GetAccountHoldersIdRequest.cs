namespace Adyen.Requests.AccountHolders;

/// <summary>
/// The inputs of the GetAccountHoldersId operation.
/// </summary>
public sealed record GetAccountHoldersIdRequest
{
    /// <summary>
    /// The unique identifier of the account holder.
    /// </summary>
    public required string Id { get; init; }
}
