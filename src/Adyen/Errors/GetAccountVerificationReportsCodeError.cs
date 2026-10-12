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

    private static Task<GetAccountVerificationReportsCodeError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 404 or 422 or 429 or 500 => response.Json<DefaultErrorResponseEntity>().As(
                AsDefaultErrorResponseEntity),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<GetAccountVerificationReportsCodeError> Response { get; } = new(Create);
}
