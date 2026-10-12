namespace Adyen.Requests.TransferLimitsBalanceAccountLevel;

/// <summary>
/// The inputs of the DeleteBalanceAccountsIdTransferLimitsTransferLimitId operation.
/// </summary>
public sealed record DeleteBalanceAccountsIdTransferLimitsTransferLimitIdRequest
{
    /// <summary>
    /// The unique identifier of the balance account.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// The unique identifier of the transfer limit.
    /// </summary>
    public required string TransferLimitId { get; init; }
}
