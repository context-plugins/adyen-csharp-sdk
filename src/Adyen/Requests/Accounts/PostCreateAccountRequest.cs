using Adyen.Models;

namespace Adyen.Requests.Accounts;

/// <summary>
/// The inputs of the PostCreateAccount operation.
/// </summary>
public sealed record PostCreateAccountRequest
{
    public CreateAccountRequest? Body { get; init; }
}
