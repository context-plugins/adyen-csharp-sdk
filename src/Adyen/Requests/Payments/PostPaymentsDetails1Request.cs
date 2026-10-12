using Adyen.Models.AllOf;

namespace Adyen.Requests.Payments;

/// <summary>
/// The inputs of the PostPaymentsDetails1 operation.
/// </summary>
public sealed record PostPaymentsDetails1Request
{
    public required IdealPaymentDetailsRequest Body { get; init; }
}
