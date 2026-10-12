using Adyen.Models;

namespace Adyen.Requests.BankAccountValidation;

/// <summary>
/// The inputs of the PostValidateBankAccountIdentification operation.
/// </summary>
public sealed record PostValidateBankAccountIdentificationRequest
{
    public BankAccountIdentificationValidationRequest? Body { get; init; }
}
