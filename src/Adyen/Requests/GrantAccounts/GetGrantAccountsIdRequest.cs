namespace Adyen.Requests.GrantAccounts;

/// <summary>
/// The inputs of the GetGrantAccountsId operation.
/// </summary>
public sealed record GetGrantAccountsIdRequest
{
    /// <summary>
    /// The unique identifier of the grant account.
    /// </summary>
    public required string Id { get; init; }
}
