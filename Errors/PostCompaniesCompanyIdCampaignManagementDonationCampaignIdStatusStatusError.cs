using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError : ApiError
{
    private readonly Optional<CompaniesCampaignManagementStatusStatus400Error1> _companiesCampaignManagementStatusStatus400Error1Value;

    private readonly Optional<CompaniesCampaignManagementStatusStatus401Error1> _companiesCampaignManagementStatusStatus401Error1Value;

    private readonly Optional<CompaniesCampaignManagementStatusStatus403Error1> _companiesCampaignManagementStatusStatus403Error1Value;

    private readonly Optional<CompaniesCampaignManagementStatusStatus422Error1> _companiesCampaignManagementStatusStatus422Error1Value;

    private readonly Optional<CompaniesCampaignManagementStatusStatus500Error1> _companiesCampaignManagementStatusStatus500Error1Value;

    private PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError(Optional<CompaniesCampaignManagementStatusStatus400Error1> companiesCampaignManagementStatusStatus400Error1Value,
        Optional<CompaniesCampaignManagementStatusStatus401Error1> companiesCampaignManagementStatusStatus401Error1Value,
        Optional<CompaniesCampaignManagementStatusStatus403Error1> companiesCampaignManagementStatusStatus403Error1Value,
        Optional<CompaniesCampaignManagementStatusStatus422Error1> companiesCampaignManagementStatusStatus422Error1Value,
        Optional<CompaniesCampaignManagementStatusStatus500Error1> companiesCampaignManagementStatusStatus500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _companiesCampaignManagementStatusStatus400Error1Value = companiesCampaignManagementStatusStatus400Error1Value;
        _companiesCampaignManagementStatusStatus401Error1Value = companiesCampaignManagementStatusStatus401Error1Value;
        _companiesCampaignManagementStatusStatus403Error1Value = companiesCampaignManagementStatusStatus403Error1Value;
        _companiesCampaignManagementStatusStatus422Error1Value = companiesCampaignManagementStatusStatus422Error1Value;
        _companiesCampaignManagementStatusStatus500Error1Value = companiesCampaignManagementStatusStatus500Error1Value;
    }

    private static PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError AsCompaniesCampaignManagementStatusStatus400Error1(CompaniesCampaignManagementStatusStatus400Error1 value) =>
        new(Optional<CompaniesCampaignManagementStatusStatus400Error1>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError AsCompaniesCampaignManagementStatusStatus401Error1(CompaniesCampaignManagementStatusStatus401Error1 value) =>
        new(default,
            Optional<CompaniesCampaignManagementStatusStatus401Error1>.Some(value),
            default,
            default,
            default,
            default);

    private static PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError AsCompaniesCampaignManagementStatusStatus403Error1(CompaniesCampaignManagementStatusStatus403Error1 value) =>
        new(default,
            default,
            Optional<CompaniesCampaignManagementStatusStatus403Error1>.Some(value),
            default,
            default,
            default);

    private static PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError AsCompaniesCampaignManagementStatusStatus422Error1(CompaniesCampaignManagementStatusStatus422Error1 value) =>
        new(default,
            default,
            default,
            Optional<CompaniesCampaignManagementStatusStatus422Error1>.Some(value),
            default,
            default);

    private static PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError AsCompaniesCampaignManagementStatusStatus500Error1(CompaniesCampaignManagementStatusStatus500Error1 value) =>
        new(default,
            default,
            default,
            default,
            Optional<CompaniesCampaignManagementStatusStatus500Error1>.Some(value),
            default);

    private static PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetCompaniesCampaignManagementStatusStatus400Error1(out CompaniesCampaignManagementStatusStatus400Error1 value) =>
        _companiesCampaignManagementStatusStatus400Error1Value.TryGetValue(out value);

    public bool TryGetCompaniesCampaignManagementStatusStatus401Error1(out CompaniesCampaignManagementStatusStatus401Error1 value) =>
        _companiesCampaignManagementStatusStatus401Error1Value.TryGetValue(out value);

    public bool TryGetCompaniesCampaignManagementStatusStatus403Error1(out CompaniesCampaignManagementStatusStatus403Error1 value) =>
        _companiesCampaignManagementStatusStatus403Error1Value.TryGetValue(out value);

    public bool TryGetCompaniesCampaignManagementStatusStatus422Error1(out CompaniesCampaignManagementStatusStatus422Error1 value) =>
        _companiesCampaignManagementStatusStatus422Error1Value.TryGetValue(out value);

    public bool TryGetCompaniesCampaignManagementStatusStatus500Error1(out CompaniesCampaignManagementStatusStatus500Error1 value) =>
        _companiesCampaignManagementStatusStatus500Error1Value.TryGetValue(out value);

    internal static Task<PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<CompaniesCampaignManagementStatusStatus400Error1>(response, ct).As(AsCompaniesCampaignManagementStatusStatus400Error1),
            401 => FromJson<CompaniesCampaignManagementStatusStatus401Error1>(response, ct).As(AsCompaniesCampaignManagementStatusStatus401Error1),
            403 => FromJson<CompaniesCampaignManagementStatusStatus403Error1>(response, ct).As(AsCompaniesCampaignManagementStatusStatus403Error1),
            422 => FromJson<CompaniesCampaignManagementStatusStatus422Error1>(response, ct).As(AsCompaniesCampaignManagementStatusStatus422Error1),
            500 => FromJson<CompaniesCampaignManagementStatusStatus500Error1>(response, ct).As(AsCompaniesCampaignManagementStatusStatus500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusErrorResponse : IErrorResponse<PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError>
{
    public static PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusErrorResponse Instance { get; } = new();

    private PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusErrorResponse()
    {
    }

    public Task<PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError.Create(response, ct);
}
