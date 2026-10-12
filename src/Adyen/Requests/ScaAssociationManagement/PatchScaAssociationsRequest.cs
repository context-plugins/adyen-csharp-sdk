using System.ComponentModel.DataAnnotations;
using Adyen.Models;

namespace Adyen.Requests.ScaAssociationManagement;

/// <summary>
/// The inputs of the PatchScaAssociations operation.
/// </summary>
public sealed record PatchScaAssociationsRequest
{
    /// <summary>
    /// The header for authenticating through SCA.
    /// </summary>
    [StringLength(20000, MinimumLength = 1)]
    public required string WwwAuthenticate { get; init; }

    public ApproveAssociationRequest? Body { get; init; }
}
