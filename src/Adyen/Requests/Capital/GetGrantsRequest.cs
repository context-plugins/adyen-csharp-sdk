namespace Adyen.Requests.Capital;

/// <summary>
/// The inputs of the GetGrants operation.
/// </summary>
public sealed record GetGrantsRequest
{
    /// <summary>
    /// The counterparty account holder id.
    /// </summary>
    public string? CounterpartyAccountHolderId { get; init; }
}
