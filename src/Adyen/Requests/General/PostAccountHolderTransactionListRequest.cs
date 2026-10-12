using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostAccountHolderTransactionList operation.
/// </summary>
public sealed record PostAccountHolderTransactionListRequest
{
    public AccountHolderTransactionListRequest? Body { get; init; }
}
