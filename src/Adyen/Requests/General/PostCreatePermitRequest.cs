using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostCreatePermit operation.
/// </summary>
public sealed record PostCreatePermitRequest
{
    public CreatePermitRequest? Body { get; init; }
}
