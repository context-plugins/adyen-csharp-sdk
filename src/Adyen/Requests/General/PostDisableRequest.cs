using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostDisable operation.
/// </summary>
public sealed record PostDisableRequest
{
    public DisableRequest? Body { get; init; }
}
