namespace Adyen.Requests.Transactions;

/// <summary>
/// The inputs of the GetTransactionsId operation.
/// </summary>
public sealed record GetTransactionsIdRequest
{
    /// <summary>
    /// The unique identifier of the transaction.
    /// </summary>
    public required string Id { get; init; }
}
