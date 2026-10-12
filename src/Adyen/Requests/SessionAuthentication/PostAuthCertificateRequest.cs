using Adyen.Models;

namespace Adyen.Requests.SessionAuthentication;

/// <summary>
/// The inputs of the PostAuthCertificate operation.
/// </summary>
public sealed record PostAuthCertificateRequest
{
    /// <summary>
    /// The API key to authenticate API requests.
    /// </summary>
    public string? XApiKey { get; init; }

    public CertificateLoadingRequest? Body { get; init; }
}
