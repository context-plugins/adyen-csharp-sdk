using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostCompaniesCompanyIdNonprofitsError : ApiError
{
    private readonly Optional<CompaniesNonprofits400Error1> _companiesNonprofits400Error1Value;

    private readonly Optional<CompaniesNonprofits401Error1> _companiesNonprofits401Error1Value;

    private readonly Optional<CompaniesNonprofits403Error1> _companiesNonprofits403Error1Value;

    private readonly Optional<CompaniesNonprofits422Error1> _companiesNonprofits422Error1Value;

    private readonly Optional<CompaniesNonprofits500Error1> _companiesNonprofits500Error1Value;

    private PostCompaniesCompanyIdNonprofitsError(Optional<CompaniesNonprofits400Error1> companiesNonprofits400Error1Value,
        Optional<CompaniesNonprofits401Error1> companiesNonprofits401Error1Value,
        Optional<CompaniesNonprofits403Error1> companiesNonprofits403Error1Value,
        Optional<CompaniesNonprofits422Error1> companiesNonprofits422Error1Value,
        Optional<CompaniesNonprofits500Error1> companiesNonprofits500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _companiesNonprofits400Error1Value = companiesNonprofits400Error1Value;
        _companiesNonprofits401Error1Value = companiesNonprofits401Error1Value;
        _companiesNonprofits403Error1Value = companiesNonprofits403Error1Value;
        _companiesNonprofits422Error1Value = companiesNonprofits422Error1Value;
        _companiesNonprofits500Error1Value = companiesNonprofits500Error1Value;
    }

    private static PostCompaniesCompanyIdNonprofitsError AsCompaniesNonprofits400Error1(CompaniesNonprofits400Error1 value) =>
        new(Optional<CompaniesNonprofits400Error1>.Some(value), default, default, default, default, default);

    private static PostCompaniesCompanyIdNonprofitsError AsCompaniesNonprofits401Error1(CompaniesNonprofits401Error1 value) =>
        new(default, Optional<CompaniesNonprofits401Error1>.Some(value), default, default, default, default);

    private static PostCompaniesCompanyIdNonprofitsError AsCompaniesNonprofits403Error1(CompaniesNonprofits403Error1 value) =>
        new(default, default, Optional<CompaniesNonprofits403Error1>.Some(value), default, default, default);

    private static PostCompaniesCompanyIdNonprofitsError AsCompaniesNonprofits422Error1(CompaniesNonprofits422Error1 value) =>
        new(default, default, default, Optional<CompaniesNonprofits422Error1>.Some(value), default, default);

    private static PostCompaniesCompanyIdNonprofitsError AsCompaniesNonprofits500Error1(CompaniesNonprofits500Error1 value) =>
        new(default, default, default, default, Optional<CompaniesNonprofits500Error1>.Some(value), default);

    private static PostCompaniesCompanyIdNonprofitsError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetCompaniesNonprofits400Error1(out CompaniesNonprofits400Error1 value) =>
        _companiesNonprofits400Error1Value.TryGetValue(out value);

    public bool TryGetCompaniesNonprofits401Error1(out CompaniesNonprofits401Error1 value) =>
        _companiesNonprofits401Error1Value.TryGetValue(out value);

    public bool TryGetCompaniesNonprofits403Error1(out CompaniesNonprofits403Error1 value) =>
        _companiesNonprofits403Error1Value.TryGetValue(out value);

    public bool TryGetCompaniesNonprofits422Error1(out CompaniesNonprofits422Error1 value) =>
        _companiesNonprofits422Error1Value.TryGetValue(out value);

    public bool TryGetCompaniesNonprofits500Error1(out CompaniesNonprofits500Error1 value) =>
        _companiesNonprofits500Error1Value.TryGetValue(out value);

    internal static Task<PostCompaniesCompanyIdNonprofitsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<CompaniesNonprofits400Error1>(response, ct).As(AsCompaniesNonprofits400Error1),
            401 => FromJson<CompaniesNonprofits401Error1>(response, ct).As(AsCompaniesNonprofits401Error1),
            403 => FromJson<CompaniesNonprofits403Error1>(response, ct).As(AsCompaniesNonprofits403Error1),
            422 => FromJson<CompaniesNonprofits422Error1>(response, ct).As(AsCompaniesNonprofits422Error1),
            500 => FromJson<CompaniesNonprofits500Error1>(response, ct).As(AsCompaniesNonprofits500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostCompaniesCompanyIdNonprofitsErrorResponse : IErrorResponse<PostCompaniesCompanyIdNonprofitsError>
{
    public static PostCompaniesCompanyIdNonprofitsErrorResponse Instance { get; } = new();

    private PostCompaniesCompanyIdNonprofitsErrorResponse()
    {
    }

    public Task<PostCompaniesCompanyIdNonprofitsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostCompaniesCompanyIdNonprofitsError.Create(response, ct);
}
