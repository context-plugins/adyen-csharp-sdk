using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostBalancePlatformsIdTransferLimitsError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private PostBalancePlatformsIdTransferLimitsError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static PostBalancePlatformsIdTransferLimitsError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static PostBalancePlatformsIdTransferLimitsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<PostBalancePlatformsIdTransferLimitsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 or 422 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostBalancePlatformsIdTransferLimitsErrorResponse : IErrorResponse<PostBalancePlatformsIdTransferLimitsError>
{
    public static PostBalancePlatformsIdTransferLimitsErrorResponse Instance { get; } = new();

    private PostBalancePlatformsIdTransferLimitsErrorResponse()
    {
    }

    public Task<PostBalancePlatformsIdTransferLimitsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostBalancePlatformsIdTransferLimitsError.Create(response, ct);
}
