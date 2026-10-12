using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostDisablePermit operation.
/// </summary>
public sealed record PostDisablePermitRequest
{
    public DisablePermitRequest? Body { get; init; }
}
