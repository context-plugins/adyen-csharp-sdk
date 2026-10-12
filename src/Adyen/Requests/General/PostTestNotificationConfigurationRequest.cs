using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostTestNotificationConfiguration operation.
/// </summary>
public sealed record PostTestNotificationConfigurationRequest
{
    public TestNotificationConfigurationRequest? Body { get; init; }
}
