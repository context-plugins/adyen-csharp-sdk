using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostGetTerminalsUnderAccount operation.
/// </summary>
public sealed record PostGetTerminalsUnderAccountRequest
{
    public GetTerminalsUnderAccountRequest? Body { get; init; }
}
