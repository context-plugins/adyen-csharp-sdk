using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostCreateNotificationConfiguration operation.
/// </summary>
public sealed record PostCreateNotificationConfigurationRequest
{
    public CreateNotificationConfigurationRequest? Body { get; init; }
}
