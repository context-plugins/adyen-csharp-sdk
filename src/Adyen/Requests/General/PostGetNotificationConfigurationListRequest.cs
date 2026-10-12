namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostGetNotificationConfigurationList operation.
/// </summary>
public sealed record PostGetNotificationConfigurationListRequest
{
    public object? Body { get; init; }
}
