using System.ComponentModel.DataAnnotations;
using Adyen.Models;

namespace Adyen.Requests.ScaAssociationManagement;

/// <summary>
/// The inputs of the DeleteScaAssociations operation.
/// </summary>
public sealed record DeleteScaAssociationsRequest
{
    /// <summary>
    /// The header for authenticating through SCA.
    /// </summary>
    [StringLength(20000, MinimumLength = 1)]
    public required string WwwAuthenticate { get; init; }

    public RemoveAssociationRequest? Body { get; init; }
}
