using Adyen.Models;

namespace Adyen.Requests.TransferLimitsBalanceAccountLevel;

/// <summary>
/// The inputs of the PostBalanceAccountsIdTransferLimits operation.
/// </summary>
public sealed record PostBalanceAccountsIdTransferLimitsRequest
{
    /// <summary>
    /// The unique identifier of the balance account.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// Header for authenticating through SCA
    /// </summary>
    public string? WwwAuthenticate { get; init; }

    public required CreateTransferLimitRequest Body { get; init; }
}
