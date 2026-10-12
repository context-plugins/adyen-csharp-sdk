using Adyen.Models;

namespace Adyen.Requests.AccountHolders;

/// <summary>
/// The inputs of the PostGetTaxForm operation.
/// </summary>
public sealed record PostGetTaxFormRequest
{
    public GetTaxFormRequest? Body { get; init; }
}
