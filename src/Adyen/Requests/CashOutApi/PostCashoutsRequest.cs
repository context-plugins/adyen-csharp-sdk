using Adyen.Models;

namespace Adyen.Requests.CashOutApi;

/// <summary>
/// The inputs of the PostCashouts operation.
/// </summary>
public sealed record PostCashoutsRequest
{
    public required CashOutInfo Body { get; init; }
}
