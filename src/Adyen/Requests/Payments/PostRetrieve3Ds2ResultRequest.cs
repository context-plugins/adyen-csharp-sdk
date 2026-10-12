using Adyen.Models;

namespace Adyen.Requests.Payments;

/// <summary>
/// The inputs of the PostRetrieve3Ds2Result operation.
/// </summary>
public sealed record PostRetrieve3Ds2ResultRequest
{
    public ThreeDs2ResultRequest? Body { get; init; }
}
