namespace Adyen.Requests.LegalEntities;

/// <summary>
/// The inputs of the GetLegalEntitiesIdBusinessLines operation.
/// </summary>
public sealed record GetLegalEntitiesIdBusinessLinesRequest
{
    /// <summary>
    /// The unique identifier of the legal entity.
    /// </summary>
    public required string Id { get; init; }
}
