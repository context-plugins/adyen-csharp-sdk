namespace Adyen.Requests.MyApiCredential;

/// <summary>
/// The inputs of the DeleteMeAllowedOriginsOriginId operation.
/// </summary>
public sealed record DeleteMeAllowedOriginsOriginIdRequest
{
    /// <summary>
    /// Unique identifier of the allowed origin.
    /// </summary>
    public required string OriginId { get; init; }
}
