using Adyen.Models;

namespace Adyen.Requests.TerminalOrdersCompanyLevel;

/// <summary>
/// The inputs of the PostCompaniesCompanyIdTerminalOrders operation.
/// </summary>
public sealed record PostCompaniesCompanyIdTerminalOrdersRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    public TerminalOrderRequest? Body { get; init; }
}
