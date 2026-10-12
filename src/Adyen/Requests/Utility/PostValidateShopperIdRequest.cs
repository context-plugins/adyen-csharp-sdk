using Adyen.Models;

namespace Adyen.Requests.Utility;

/// <summary>
/// The inputs of the PostValidateShopperId operation.
/// </summary>
public sealed record PostValidateShopperIdRequest
{
    public required ValidateShopperIdRequest Body { get; init; }
}
