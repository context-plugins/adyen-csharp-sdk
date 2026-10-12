using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostNotifyShopper operation.
/// </summary>
public sealed record PostNotifyShopperRequest
{
    public NotifyShopperRequest? Body { get; init; }
}
