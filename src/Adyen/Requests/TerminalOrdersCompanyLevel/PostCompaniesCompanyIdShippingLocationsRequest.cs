using Adyen.Models;

namespace Adyen.Requests.TerminalOrdersCompanyLevel;

/// <summary>
/// The inputs of the PostCompaniesCompanyIdShippingLocations operation.
/// </summary>
public sealed record PostCompaniesCompanyIdShippingLocationsRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    public ShippingLocation? Body { get; init; }
}
