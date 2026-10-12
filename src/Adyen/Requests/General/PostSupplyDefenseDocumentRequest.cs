using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostSupplyDefenseDocument operation.
/// </summary>
public sealed record PostSupplyDefenseDocumentRequest
{
    public SupplyDefenseDocumentRequest? Body { get; init; }
}
