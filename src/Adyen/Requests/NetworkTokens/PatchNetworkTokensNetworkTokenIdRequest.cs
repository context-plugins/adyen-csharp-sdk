using Adyen.Models;

namespace Adyen.Requests.NetworkTokens;

/// <summary>
/// The inputs of the PatchNetworkTokensNetworkTokenId operation.
/// </summary>
public sealed record PatchNetworkTokensNetworkTokenIdRequest
{
    /// <summary>
    /// The unique identifier of the network token.
    /// </summary>
    public required string NetworkTokenId { get; init; }

    public UpdateNetworkTokenRequest? Body { get; init; }
}
