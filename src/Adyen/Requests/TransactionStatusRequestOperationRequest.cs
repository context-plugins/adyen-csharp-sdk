using Adyen.Models;

namespace Adyen.Requests;

/// <summary>
/// The inputs of the TransactionStatusRequest operation.
/// </summary>
public sealed record TransactionStatusRequestOperationRequest
{
    public TransactionStatusRequest? Body { get; init; }
}
