using Adyen.Models;

namespace Adyen.Requests.BalanceAccounts;

/// <summary>
/// The inputs of the PatchBalanceAccountsId operation.
/// </summary>
public sealed record PatchBalanceAccountsIdRequest
{
    /// <summary>
    /// The unique identifier of the balance account.
    /// </summary>
    public required string Id { get; init; }

    public BalanceAccountUpdateRequest? Body { get; init; }
}
