namespace Adyen.Requests.TaxEDeliveryConsent;

/// <summary>
/// The inputs of the PostLegalEntitiesIdCheckTaxElectronicDeliveryConsent operation.
/// </summary>
public sealed record PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentRequest
{
    /// <summary>
    /// The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization.
    /// </summary>
    public required string Id { get; init; }
}
