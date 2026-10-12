namespace Adyen.Requests.GrantsApi;

/// <summary>
/// The inputs of the GetGrants2 operation.
/// </summary>
public sealed record GetGrants2Request
{
    /// <summary>
    /// The unique identifier of the account holder that received the grants.
    /// </summary>
    public required string CounterpartyAccountHolderId { get; init; }
}
