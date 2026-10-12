using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostVoidTransaction operation.
/// </summary>
public sealed record PostVoidTransactionRequest
{
    public StoredValueVoidRequest? Body { get; init; }
}
