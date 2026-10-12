using Adyen.Models;

namespace Adyen.Requests.Rates;

/// <summary>
/// The inputs of the PostRatesCalculate operation.
/// </summary>
public sealed record PostRatesCalculateRequest
{
    public required CalculateRateRequest Body { get; init; }
}
