using Adyen.Models;

namespace Adyen.Requests.Verification;

/// <summary>
/// The inputs of the PostDeleteShareholders operation.
/// </summary>
public sealed record PostDeleteShareholdersRequest
{
    public DeleteShareholderRequest? Body { get; init; }
}
