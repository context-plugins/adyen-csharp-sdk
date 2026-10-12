using Adyen.Models.Enums;

namespace Adyen.Requests.TransferLimitsBalanceAccountLevel;

/// <summary>
/// The inputs of the GetBalanceAccountsIdTransferLimits operation.
/// </summary>
public sealed record GetBalanceAccountsIdTransferLimitsRequest
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

    /// <summary>
    /// The status of the transfer limit. Possible values:
    /// * <b>active</b>: the limit is currently active.
    /// * <b>inactive</b>: the limit is currently inactive.
    /// * <b>pendingSCA</b>: the limit is pending until your user performs SCA.
    /// * <b>scheduled</b>: the limit is scheduled to become active at a future date.
    /// </summary>
    public LimitStatus? Status { get; init; }
}
