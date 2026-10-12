namespace Adyen.Requests.Payments;

/// <summary>
/// The inputs of the GetSessionsSessionId operation.
/// </summary>
public sealed record GetSessionsSessionIdRequest
{
    /// <summary>
    /// A unique identifier of the session.
    /// </summary>
    public required string SessionId { get; init; }

    /// <summary>
    /// The <c>sessionResult</c> value from the Drop-in or Component.
    /// </summary>
    public required string SessionResult { get; init; }
}
