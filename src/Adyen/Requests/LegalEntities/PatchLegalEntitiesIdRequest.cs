using Adyen.Models;

namespace Adyen.Requests.LegalEntities;

/// <summary>
/// The inputs of the PatchLegalEntitiesId operation.
/// </summary>
public sealed record PatchLegalEntitiesIdRequest
{
    /// <summary>
    /// The unique identifier of the legal entity.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// Use the requested verification code 0_0001 to resolve any suberrors associated with the legal entity. Requested verification codes can only be used in your test environment.
    /// </summary>
    public string? XRequestedVerificationCode { get; init; }

    public LegalEntityInfo? Body { get; init; }
}
