using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetBalancePlatformsIdTransferLimitsTransferLimitIdError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private GetBalancePlatformsIdTransferLimitsTransferLimitIdError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static GetBalancePlatformsIdTransferLimitsTransferLimitIdError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static GetBalancePlatformsIdTransferLimitsTransferLimitIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<GetBalancePlatformsIdTransferLimitsTransferLimitIdError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 or 422 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetBalancePlatformsIdTransferLimitsTransferLimitIdErrorResponse : IErrorResponse<GetBalancePlatformsIdTransferLimitsTransferLimitIdError>
{
    public static GetBalancePlatformsIdTransferLimitsTransferLimitIdErrorResponse Instance { get; } = new();

    private GetBalancePlatformsIdTransferLimitsTransferLimitIdErrorResponse()
    {
    }

    public Task<GetBalancePlatformsIdTransferLimitsTransferLimitIdError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetBalancePlatformsIdTransferLimitsTransferLimitIdError.Create(response, ct);
}
