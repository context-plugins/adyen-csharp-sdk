using Adyen.Models;

namespace Adyen.Requests.AccountHolders;

/// <summary>
/// The inputs of the PatchAccountHoldersId operation.
/// </summary>
public sealed record PatchAccountHoldersIdRequest
{
    /// <summary>
    /// The unique identifier of the account holder.
    /// </summary>
    public required string Id { get; init; }

    public AccountHolderUpdateRequest? Body { get; init; }
}
