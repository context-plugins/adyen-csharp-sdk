using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostUpdateNotificationConfiguration operation.
/// </summary>
public sealed record PostUpdateNotificationConfigurationRequest
{
    public UpdateNotificationConfigurationRequest? Body { get; init; }
}
