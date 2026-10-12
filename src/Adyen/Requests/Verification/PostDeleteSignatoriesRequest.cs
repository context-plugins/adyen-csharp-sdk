using Adyen.Models;

namespace Adyen.Requests.Verification;

/// <summary>
/// The inputs of the PostDeleteSignatories operation.
/// </summary>
public sealed record PostDeleteSignatoriesRequest
{
    public DeleteSignatoriesRequest? Body { get; init; }
}
