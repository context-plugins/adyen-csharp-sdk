namespace Adyen.Requests.NetworkTokens;

/// <summary>
/// The inputs of the GetNetworkTokensNetworkTokenId operation.
/// </summary>
public sealed record GetNetworkTokensNetworkTokenIdRequest
{
    /// <summary>
    /// The unique identifier of the network token.
    /// </summary>
    public required string NetworkTokenId { get; init; }
}
