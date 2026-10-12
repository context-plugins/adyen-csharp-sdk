namespace Adyen.Requests.GrantAccounts;

/// <summary>
/// The inputs of the GetGrantAccountsId1 operation.
/// </summary>
public sealed record GetGrantAccountsId1Request
{
    /// <summary>
    /// The unique identifier of the grant account.
    /// </summary>
    public required string Id { get; init; }
}
