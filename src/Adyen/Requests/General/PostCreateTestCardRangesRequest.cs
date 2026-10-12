using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostCreateTestCardRanges operation.
/// </summary>
public sealed record PostCreateTestCardRangesRequest
{
    public CreateTestCardRangesRequest? Body { get; init; }
}
