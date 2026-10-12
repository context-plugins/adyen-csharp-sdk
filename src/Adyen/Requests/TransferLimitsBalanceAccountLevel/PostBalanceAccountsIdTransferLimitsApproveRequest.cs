using Adyen.Models;

namespace Adyen.Requests.TransferLimitsBalanceAccountLevel;

/// <summary>
/// The inputs of the PostBalanceAccountsIdTransferLimitsApprove operation.
/// </summary>
public sealed record PostBalanceAccountsIdTransferLimitsApproveRequest
{
    /// <summary>
    /// The unique identifier of the balance account.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// Header for authenticating using SCA.
    /// </summary>
    public string? WwwAuthenticate { get; init; }

    public required ApproveTransferLimitRequest Body { get; init; }
}
