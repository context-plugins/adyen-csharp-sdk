namespace Adyen.Requests.LegalEntities;

/// <summary>
/// The inputs of the PostLegalEntitiesIdCheckVerificationErrors operation.
/// </summary>
public sealed record PostLegalEntitiesIdCheckVerificationErrorsRequest
{
    /// <summary>
    /// The unique identifier of the legal entity.
    /// </summary>
    public required string Id { get; init; }
}
