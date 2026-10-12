namespace Adyen.Requests.TermsOfService;

/// <summary>
/// The inputs of the GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereference operation.
/// </summary>
public sealed record GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereferenceRequest
{
    /// <summary>
    /// The unique identifier of the legal entity. For sole proprietorship, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// An Adyen-generated reference for the accepted Terms of Service.
    /// </summary>
    public required string Termsofserviceacceptancereference { get; init; }

    /// <summary>
    /// The format of the Terms of Service document. Possible values: <b>JSON</b>, <b>PDF</b>, or <b>TXT</b>
    /// </summary>
    public string? TermsOfServiceDocumentFormat { get; init; }
}
