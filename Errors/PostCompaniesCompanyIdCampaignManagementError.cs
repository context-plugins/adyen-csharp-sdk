using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostCompaniesCompanyIdCampaignManagementError : ApiError
{
    private readonly Optional<CompaniesCampaignManagement400Error1> _companiesCampaignManagement400Error1Value;

    private readonly Optional<CompaniesCampaignManagement401Error1> _companiesCampaignManagement401Error1Value;

    private readonly Optional<CompaniesCampaignManagement403Error1> _companiesCampaignManagement403Error1Value;

    private readonly Optional<CompaniesCampaignManagement422Error1> _companiesCampaignManagement422Error1Value;

    private readonly Optional<CompaniesCampaignManagement500Error1> _companiesCampaignManagement500Error1Value;

    private PostCompaniesCompanyIdCampaignManagementError(Optional<CompaniesCampaignManagement400Error1> companiesCampaignManagement400Error1Value,
        Optional<CompaniesCampaignManagement401Error1> companiesCampaignManagement401Error1Value,
        Optional<CompaniesCampaignManagement403Error1> companiesCampaignManagement403Error1Value,
        Optional<CompaniesCampaignManagement422Error1> companiesCampaignManagement422Error1Value,
        Optional<CompaniesCampaignManagement500Error1> companiesCampaignManagement500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _companiesCampaignManagement400Error1Value = companiesCampaignManagement400Error1Value;
        _companiesCampaignManagement401Error1Value = companiesCampaignManagement401Error1Value;
        _companiesCampaignManagement403Error1Value = companiesCampaignManagement403Error1Value;
        _companiesCampaignManagement422Error1Value = companiesCampaignManagement422Error1Value;
        _companiesCampaignManagement500Error1Value = companiesCampaignManagement500Error1Value;
    }

    private static PostCompaniesCompanyIdCampaignManagementError AsCompaniesCampaignManagement400Error1(CompaniesCampaignManagement400Error1 value) =>
        new(Optional<CompaniesCampaignManagement400Error1>.Some(value), default, default, default, default, default);

    private static PostCompaniesCompanyIdCampaignManagementError AsCompaniesCampaignManagement401Error1(CompaniesCampaignManagement401Error1 value) =>
        new(default, Optional<CompaniesCampaignManagement401Error1>.Some(value), default, default, default, default);

    private static PostCompaniesCompanyIdCampaignManagementError AsCompaniesCampaignManagement403Error1(CompaniesCampaignManagement403Error1 value) =>
        new(default, default, Optional<CompaniesCampaignManagement403Error1>.Some(value), default, default, default);

    private static PostCompaniesCompanyIdCampaignManagementError AsCompaniesCampaignManagement422Error1(CompaniesCampaignManagement422Error1 value) =>
        new(default, default, default, Optional<CompaniesCampaignManagement422Error1>.Some(value), default, default);

    private static PostCompaniesCompanyIdCampaignManagementError AsCompaniesCampaignManagement500Error1(CompaniesCampaignManagement500Error1 value) =>
        new(default, default, default, default, Optional<CompaniesCampaignManagement500Error1>.Some(value), default);

    private static PostCompaniesCompanyIdCampaignManagementError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetCompaniesCampaignManagement400Error1(out CompaniesCampaignManagement400Error1 value) =>
        _companiesCampaignManagement400Error1Value.TryGetValue(out value);

    public bool TryGetCompaniesCampaignManagement401Error1(out CompaniesCampaignManagement401Error1 value) =>
        _companiesCampaignManagement401Error1Value.TryGetValue(out value);

    public bool TryGetCompaniesCampaignManagement403Error1(out CompaniesCampaignManagement403Error1 value) =>
        _companiesCampaignManagement403Error1Value.TryGetValue(out value);

    public bool TryGetCompaniesCampaignManagement422Error1(out CompaniesCampaignManagement422Error1 value) =>
        _companiesCampaignManagement422Error1Value.TryGetValue(out value);

    public bool TryGetCompaniesCampaignManagement500Error1(out CompaniesCampaignManagement500Error1 value) =>
        _companiesCampaignManagement500Error1Value.TryGetValue(out value);

    internal static Task<PostCompaniesCompanyIdCampaignManagementError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<CompaniesCampaignManagement400Error1>(response, ct).As(AsCompaniesCampaignManagement400Error1),
            401 => FromJson<CompaniesCampaignManagement401Error1>(response, ct).As(AsCompaniesCampaignManagement401Error1),
            403 => FromJson<CompaniesCampaignManagement403Error1>(response, ct).As(AsCompaniesCampaignManagement403Error1),
            422 => FromJson<CompaniesCampaignManagement422Error1>(response, ct).As(AsCompaniesCampaignManagement422Error1),
            500 => FromJson<CompaniesCampaignManagement500Error1>(response, ct).As(AsCompaniesCampaignManagement500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostCompaniesCompanyIdCampaignManagementErrorResponse : IErrorResponse<PostCompaniesCompanyIdCampaignManagementError>
{
    public static PostCompaniesCompanyIdCampaignManagementErrorResponse Instance { get; } = new();

    private PostCompaniesCompanyIdCampaignManagementErrorResponse()
    {
    }

    public Task<PostCompaniesCompanyIdCampaignManagementError> Map(HttpResponseMessage response,
        CancellationToken ct) => PostCompaniesCompanyIdCampaignManagementError.Create(response, ct);
}
