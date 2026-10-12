using Adyen.Models;

namespace Adyen.Requests.IDealProfiles;

/// <summary>
/// The inputs of the PostIdealProfileRegister operation.
/// </summary>
public sealed record PostIdealProfileRegisterRequest
{
    public required ProfileRegistrationRequest Body { get; init; }
}
