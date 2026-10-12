using Adyen.Models;

namespace Adyen.Requests.MyApiCredential;

/// <summary>
/// The inputs of the PostMeAllowedOrigins operation.
/// </summary>
public sealed record PostMeAllowedOriginsRequest
{
    public CreateAllowedOriginRequest? Body { get; init; }
}
