using Adyen.Models;

namespace Adyen.Requests.GrantsApi;

/// <summary>
/// The inputs of the PostGrants2 operation.
/// </summary>
public sealed record PostGrants2Request
{
    public CapitalGrantInfo? Body { get; init; }
}
