namespace Adyen.Requests.GrantOffersApi;

/// <summary>
/// The inputs of the GetGrantOffersId operation.
/// </summary>
public sealed record GetGrantOffersIdRequest
{
    /// <summary>
    /// The unique identifier of the static offer.
    /// </summary>
    public required string Id { get; init; }
}
