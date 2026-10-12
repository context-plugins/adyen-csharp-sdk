using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Adyen.Core.Validation.Attributes;
using Adyen.Models;

namespace Adyen.Requests.DonationCampaigns;

/// <summary>
/// The inputs of the PostCompaniesCompanyIdNonprofits operation.
/// </summary>
public sealed record PostCompaniesCompanyIdNonprofitsRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// A query to return nonprofit organizations for, maximum 100 characters. For example, <c>&amp;searchTerm=clean%20water</c>.
    /// </summary>
    [StringLength(100, MinimumLength = 1)]
    public string? SearchTerm { get; init; }

    /// <summary>
    /// The number of the page to fetch.
    /// </summary>
    [Minimum(1)]
    public int? PageNumber { get; init; }

    /// <summary>
    /// The number of items to have on a page, maximum 100. The default is 10 items on a page.
    /// </summary>
    [Minimum(1)]
    [Maximum(100)]
    public int PageSize { get; init; } = 10;

    /// <summary>
    /// One or more United Nations Sustainable Development Goals to return nonprofit organizations for. Format: <c>unsdg_&lt;number&gt;</c>, for example, <c>&amp;goal=unsdg_6&amp;goal=unsdg_2</c>.
    /// </summary>
    public IReadOnlyList<string>? Goal { get; init; }

    public ListNonprofitsRequest? Body { get; init; }
}
