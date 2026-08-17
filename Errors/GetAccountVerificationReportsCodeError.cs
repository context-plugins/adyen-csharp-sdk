using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetAccountVerificationReportsCodeError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private GetAccountVerificationReportsCodeError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static GetAccountVerificationReportsCodeError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static GetAccountVerificationReportsCodeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<GetAccountVerificationReportsCodeError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 404 or 422 or 429 or 500 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAccountVerificationReportsCodeErrorResponse : IErrorResponse<GetAccountVerificationReportsCodeError>
{
    public static GetAccountVerificationReportsCodeErrorResponse Instance { get; } = new();

    private GetAccountVerificationReportsCodeErrorResponse()
    {
    }

    public Task<GetAccountVerificationReportsCodeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAccountVerificationReportsCodeError.Create(response, ct);
}
