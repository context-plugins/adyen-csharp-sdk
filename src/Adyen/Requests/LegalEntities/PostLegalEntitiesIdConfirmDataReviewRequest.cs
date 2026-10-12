namespace Adyen.Requests.LegalEntities;

/// <summary>
/// The inputs of the PostLegalEntitiesIdConfirmDataReview operation.
/// </summary>
public sealed record PostLegalEntitiesIdConfirmDataReviewRequest
{
    /// <summary>
    /// The unique identifier of the legal entity.
    /// </summary>
    public required string Id { get; init; }
}
