using Adyen.Models;

namespace Adyen.Requests.Accounts;

/// <summary>
/// The inputs of the PostUpdateAccount operation.
/// </summary>
public sealed record PostUpdateAccountRequest
{
    public UpdateAccountRequest? Body { get; init; }
}
