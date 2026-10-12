using Adyen.Models;

namespace Adyen.Requests.Payments;

/// <summary>
/// The inputs of the PostPaymentsConfirm operation.
/// </summary>
public sealed record PostPaymentsConfirmRequest
{
    /// <summary>
    /// Header for authenticating through SCA: Contains information for an SCA challenge for A2A payments.
    /// </summary>
    public string? WwwAuthenticate { get; init; }

    public required ConfirmPaymentRequest Body { get; init; }
}
