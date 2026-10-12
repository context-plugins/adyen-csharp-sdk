using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostGetNotificationConfiguration operation.
/// </summary>
public sealed record PostGetNotificationConfigurationRequest
{
    public GetNotificationConfigurationRequest? Body { get; init; }
}
