using Adyen.Models;

namespace Adyen.Requests.Accounts;

/// <summary>
/// The inputs of the PostCloseAccount operation.
/// </summary>
public sealed record PostCloseAccountRequest
{
    public CloseAccountRequest? Body { get; init; }
}
