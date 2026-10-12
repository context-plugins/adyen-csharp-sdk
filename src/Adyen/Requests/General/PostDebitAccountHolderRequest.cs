using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostDebitAccountHolder operation.
/// </summary>
public sealed record PostDebitAccountHolderRequest
{
    public DebitAccountHolderRequest? Body { get; init; }
}
