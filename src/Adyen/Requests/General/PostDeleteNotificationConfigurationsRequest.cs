using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostDeleteNotificationConfigurations operation.
/// </summary>
public sealed record PostDeleteNotificationConfigurationsRequest
{
    public DeleteNotificationConfigurationRequest? Body { get; init; }
}
