namespace Adyen.Requests.LegalEntities;

/// <summary>
/// The inputs of the PostLegalEntitiesIdRequestPeriodicReview operation.
/// </summary>
public sealed record PostLegalEntitiesIdRequestPeriodicReviewRequest
{
    /// <summary>
    /// The unique identifier of the legal entity.
    /// </summary>
    public required string Id { get; init; }
}
