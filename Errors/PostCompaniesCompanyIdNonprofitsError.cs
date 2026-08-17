using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostCompaniesCompanyIdNonprofitsError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private PostCompaniesCompanyIdNonprofitsError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static PostCompaniesCompanyIdNonprofitsError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static PostCompaniesCompanyIdNonprofitsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<PostCompaniesCompanyIdNonprofitsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
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
