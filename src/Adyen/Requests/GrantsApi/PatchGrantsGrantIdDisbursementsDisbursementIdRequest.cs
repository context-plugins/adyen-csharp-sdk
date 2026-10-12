using System.ComponentModel.DataAnnotations;
using Adyen.Models;

namespace Adyen.Requests.GrantsApi;

/// <summary>
/// The inputs of the PatchGrantsGrantIdDisbursementsDisbursementId operation.
/// </summary>
public sealed record PatchGrantsGrantIdDisbursementsDisbursementIdRequest
{
    /// <summary>
    /// The unique identifier of the grant reference.
    /// </summary>
    [MinLength(1)]
    public required string GrantId { get; init; }

    /// <summary>
    /// The unique identifier of the disbursement.
    /// </summary>
    [MinLength(1)]
    public required string DisbursementId { get; init; }

    public required DisbursementInfoUpdate Body { get; init; }
}
