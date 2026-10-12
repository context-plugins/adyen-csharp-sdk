namespace Adyen.Requests.DirectDebitMandates;

/// <summary>
/// The inputs of the PostMandatesMandateIdCancel operation.
/// </summary>
public sealed record PostMandatesMandateIdCancelRequest
{
    /// <summary>
    /// The unique identifier of the mandate.
    /// </summary>
    public required string MandateId { get; init; }
}
