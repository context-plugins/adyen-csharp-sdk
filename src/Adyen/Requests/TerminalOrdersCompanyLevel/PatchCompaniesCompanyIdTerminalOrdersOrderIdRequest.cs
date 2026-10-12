using Adyen.Models;

namespace Adyen.Requests.TerminalOrdersCompanyLevel;

/// <summary>
/// The inputs of the PatchCompaniesCompanyIdTerminalOrdersOrderId operation.
/// </summary>
public sealed record PatchCompaniesCompanyIdTerminalOrdersOrderIdRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// The unique identifier of the order.
    /// </summary>
    public required string OrderId { get; init; }

    public TerminalOrderRequest? Body { get; init; }
}
