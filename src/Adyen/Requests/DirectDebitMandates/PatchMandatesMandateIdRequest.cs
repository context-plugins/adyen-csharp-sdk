using Adyen.Models;

namespace Adyen.Requests.DirectDebitMandates;

/// <summary>
/// The inputs of the PatchMandatesMandateId operation.
/// </summary>
public sealed record PatchMandatesMandateIdRequest
{
    /// <summary>
    /// The unique identifier of the mandate.
    /// </summary>
    public required string MandateId { get; init; }

    public required MandateUpdate Body { get; init; }
}
