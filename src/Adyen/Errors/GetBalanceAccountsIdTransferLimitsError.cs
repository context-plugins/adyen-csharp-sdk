using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetBalanceAccountsIdTransferLimitsError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private GetBalanceAccountsIdTransferLimitsError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static GetBalanceAccountsIdTransferLimitsError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static GetBalanceAccountsIdTransferLimitsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    private static Task<GetBalanceAccountsIdTransferLimitsError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            404 or 422 => response.Json<DefaultErrorResponseEntity>().As(AsDefaultErrorResponseEntity),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<GetBalanceAccountsIdTransferLimitsError> Response { get; } = new(Create);
}
