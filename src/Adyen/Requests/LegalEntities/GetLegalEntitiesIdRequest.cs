namespace Adyen.Requests.LegalEntities;

/// <summary>
/// The inputs of the GetLegalEntitiesId operation.
/// </summary>
public sealed record GetLegalEntitiesIdRequest
{
    /// <summary>
    /// The unique identifier of the legal entity.
    /// </summary>
    public required string Id { get; init; }
}
