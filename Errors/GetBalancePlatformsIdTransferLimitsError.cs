using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetBalancePlatformsIdTransferLimitsError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private GetBalancePlatformsIdTransferLimitsError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static GetBalancePlatformsIdTransferLimitsError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static GetBalancePlatformsIdTransferLimitsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<GetBalancePlatformsIdTransferLimitsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 or 422 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetBalancePlatformsIdTransferLimitsErrorResponse : IErrorResponse<GetBalancePlatformsIdTransferLimitsError>
{
    public static GetBalancePlatformsIdTransferLimitsErrorResponse Instance { get; } = new();

    private GetBalancePlatformsIdTransferLimitsErrorResponse()
    {
    }

    public Task<GetBalancePlatformsIdTransferLimitsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetBalancePlatformsIdTransferLimitsError.Create(response, ct);
}
