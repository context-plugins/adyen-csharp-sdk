namespace Adyen.Requests.MyApiCredential;

/// <summary>
/// The inputs of the GetMeAllowedOriginsOriginId operation.
/// </summary>
public sealed record GetMeAllowedOriginsOriginIdRequest
{
    /// <summary>
    /// Unique identifier of the allowed origin.
    /// </summary>
    public required string OriginId { get; init; }
}
