using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError : ApiError
{
    private readonly Optional<CompaniesCampaignManagementAccountHolders400Error1> _companiesCampaignManagementAccountHolders400Error1Value;

    private readonly Optional<CompaniesCampaignManagementAccountHolders401Error1> _companiesCampaignManagementAccountHolders401Error1Value;

    private readonly Optional<CompaniesCampaignManagementAccountHolders403Error1> _companiesCampaignManagementAccountHolders403Error1Value;

    private readonly Optional<CompaniesCampaignManagementAccountHolders422Error1> _companiesCampaignManagementAccountHolders422Error1Value;

    private readonly Optional<CompaniesCampaignManagementAccountHolders500Error1> _companiesCampaignManagementAccountHolders500Error1Value;

    private GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError(Optional<CompaniesCampaignManagementAccountHolders400Error1> companiesCampaignManagementAccountHolders400Error1Value,
        Optional<CompaniesCampaignManagementAccountHolders401Error1> companiesCampaignManagementAccountHolders401Error1Value,
        Optional<CompaniesCampaignManagementAccountHolders403Error1> companiesCampaignManagementAccountHolders403Error1Value,
        Optional<CompaniesCampaignManagementAccountHolders422Error1> companiesCampaignManagementAccountHolders422Error1Value,
        Optional<CompaniesCampaignManagementAccountHolders500Error1> companiesCampaignManagementAccountHolders500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _companiesCampaignManagementAccountHolders400Error1Value = companiesCampaignManagementAccountHolders400Error1Value;
        _companiesCampaignManagementAccountHolders401Error1Value = companiesCampaignManagementAccountHolders401Error1Value;
        _companiesCampaignManagementAccountHolders403Error1Value = companiesCampaignManagementAccountHolders403Error1Value;
        _companiesCampaignManagementAccountHolders422Error1Value = companiesCampaignManagementAccountHolders422Error1Value;
        _companiesCampaignManagementAccountHolders500Error1Value = companiesCampaignManagementAccountHolders500Error1Value;
    }

    private static GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError AsCompaniesCampaignManagementAccountHolders400Error1(CompaniesCampaignManagementAccountHolders400Error1 value) =>
        new(Optional<CompaniesCampaignManagementAccountHolders400Error1>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError AsCompaniesCampaignManagementAccountHolders401Error1(CompaniesCampaignManagementAccountHolders401Error1 value) =>
        new(default,
            Optional<CompaniesCampaignManagementAccountHolders401Error1>.Some(value),
            default,
            default,
            default,
            default);

    private static GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError AsCompaniesCampaignManagementAccountHolders403Error1(CompaniesCampaignManagementAccountHolders403Error1 value) =>
        new(default,
            default,
            Optional<CompaniesCampaignManagementAccountHolders403Error1>.Some(value),
            default,
            default,
            default);

    private static GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError AsCompaniesCampaignManagementAccountHolders422Error1(CompaniesCampaignManagementAccountHolders422Error1 value) =>
        new(default,
            default,
            default,
            Optional<CompaniesCampaignManagementAccountHolders422Error1>.Some(value),
            default,
            default);

    private static GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError AsCompaniesCampaignManagementAccountHolders500Error1(CompaniesCampaignManagementAccountHolders500Error1 value) =>
        new(default,
            default,
            default,
            default,
            Optional<CompaniesCampaignManagementAccountHolders500Error1>.Some(value),
            default);

    private static GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetCompaniesCampaignManagementAccountHolders400Error1(out CompaniesCampaignManagementAccountHolders400Error1 value) =>
        _companiesCampaignManagementAccountHolders400Error1Value.TryGetValue(out value);

    public bool TryGetCompaniesCampaignManagementAccountHolders401Error1(out CompaniesCampaignManagementAccountHolders401Error1 value) =>
        _companiesCampaignManagementAccountHolders401Error1Value.TryGetValue(out value);

    public bool TryGetCompaniesCampaignManagementAccountHolders403Error1(out CompaniesCampaignManagementAccountHolders403Error1 value) =>
        _companiesCampaignManagementAccountHolders403Error1Value.TryGetValue(out value);

    public bool TryGetCompaniesCampaignManagementAccountHolders422Error1(out CompaniesCampaignManagementAccountHolders422Error1 value) =>
        _companiesCampaignManagementAccountHolders422Error1Value.TryGetValue(out value);

    public bool TryGetCompaniesCampaignManagementAccountHolders500Error1(out CompaniesCampaignManagementAccountHolders500Error1 value) =>
        _companiesCampaignManagementAccountHolders500Error1Value.TryGetValue(out value);

    internal static Task<GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<CompaniesCampaignManagementAccountHolders400Error1>(response, ct).As(AsCompaniesCampaignManagementAccountHolders400Error1),
            401 => FromJson<CompaniesCampaignManagementAccountHolders401Error1>(response, ct).As(AsCompaniesCampaignManagementAccountHolders401Error1),
            403 => FromJson<CompaniesCampaignManagementAccountHolders403Error1>(response, ct).As(AsCompaniesCampaignManagementAccountHolders403Error1),
            422 => FromJson<CompaniesCampaignManagementAccountHolders422Error1>(response, ct).As(AsCompaniesCampaignManagementAccountHolders422Error1),
            500 => FromJson<CompaniesCampaignManagementAccountHolders500Error1>(response, ct).As(AsCompaniesCampaignManagementAccountHolders500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdErrorResponse : IErrorResponse<GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError>
{
    public static GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdErrorResponse Instance { get; } = new();

    private GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdErrorResponse()
    {
    }

    public Task<GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError.Create(response, ct);
}
