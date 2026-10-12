using Adyen.Models.Enums;

namespace Adyen.Requests.TransferLimitsBalanceAccountLevel;

/// <summary>
/// The inputs of the GetBalanceAccountsIdTransferLimitsCurrent operation.
/// </summary>
public sealed record GetBalanceAccountsIdTransferLimitsCurrentRequest
{
    /// <summary>
    /// The unique identifier of the balance account.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// The scope to which the transfer limit applies. Possible values:
    /// * <b>perTransaction</b>: you set a maximum amount for each transfer made from the balance account or balance platform.
    /// * <b>perDay</b>: you set a maximum total amount for all transfers made from the balance account or balance platform in a day.
    /// </summary>
    public Scope? Scope { get; init; }

    /// <summary>
    /// The type of transfer to which the limit applies. Possible values:
    /// * <b>instant</b>: the limit applies to transfers with an <b>instant</b> priority.
    /// * <b>all</b>: the limit applies to all transfers, regardless of priority.
    /// </summary>
    public TransferType? TransferType { get; init; }
}
