using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostCheckBalance operation.
/// </summary>
public sealed record PostCheckBalanceRequest
{
    public StoredValueBalanceCheckRequest? Body { get; init; }
}
