namespace Adyen.Requests.DirectDebitMandates;

/// <summary>
/// The inputs of the GetMandatesMandateId operation.
/// </summary>
public sealed record GetMandatesMandateIdRequest
{
    /// <summary>
    /// The unique identifier of the mandate.
    /// </summary>
    public required string MandateId { get; init; }
}
