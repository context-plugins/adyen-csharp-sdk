using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostSetupBeneficiary operation.
/// </summary>
public sealed record PostSetupBeneficiaryRequest
{
    public SetupBeneficiaryRequest? Body { get; init; }
}
