using Adyen.Models;

namespace Adyen.Requests.Documents;

/// <summary>
/// The inputs of the PostDocuments operation.
/// </summary>
public sealed record PostDocumentsRequest
{
    /// <summary>
    /// Use a suberror code as your requested verification code. You can include one code at a time in your request header. Requested verification codes can only be used in your test environment.
    /// </summary>
    public string? XRequestedVerificationCode { get; init; }

    public Document? Body { get; init; }
}
