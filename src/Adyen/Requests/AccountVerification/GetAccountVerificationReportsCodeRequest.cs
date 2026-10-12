using System.ComponentModel.DataAnnotations;

namespace Adyen.Requests.AccountVerification;

/// <summary>
/// The inputs of the GetAccountVerificationReportsCode operation.
/// </summary>
public sealed record GetAccountVerificationReportsCodeRequest
{
    /// <summary>
    /// The unique code you receive after a successful open banking flow that is included as a query parameter in the <c>redirectUrl</c> callback.
    /// </summary>
    [MinLength(1)]
    public required string Code { get; init; }
}
