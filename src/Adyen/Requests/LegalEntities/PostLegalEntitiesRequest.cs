using Adyen.Models;

namespace Adyen.Requests.LegalEntities;

/// <summary>
/// The inputs of the PostLegalEntities operation.
/// </summary>
public sealed record PostLegalEntitiesRequest
{
    /// <summary>
    /// Use a suberror code as your requested verification code. You can include one code at a time in your request header. Requested verification codes can only be used in your test environment.
    /// </summary>
    public string? XRequestedVerificationCode { get; init; }

    public LegalEntityInfoRequiredType? Body { get; init; }
}
