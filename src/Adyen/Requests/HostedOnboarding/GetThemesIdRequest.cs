namespace Adyen.Requests.HostedOnboarding;

/// <summary>
/// The inputs of the GetThemesId operation.
/// </summary>
public sealed record GetThemesIdRequest
{
    /// <summary>
    /// The unique identifier of the theme
    /// </summary>
    public required string Id { get; init; }
}
