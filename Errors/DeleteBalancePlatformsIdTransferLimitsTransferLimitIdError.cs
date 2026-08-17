using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class DeleteBalancePlatformsIdTransferLimitsTransferLimitIdError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private DeleteBalancePlatformsIdTransferLimitsTransferLimitIdError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static DeleteBalancePlatformsIdTransferLimitsTransferLimitIdError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static DeleteBalancePlatformsIdTransferLimitsTransferLimitIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<DeleteBalancePlatformsIdTransferLimitsTransferLimitIdError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 or 422 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteBalancePlatformsIdTransferLimitsTransferLimitIdErrorResponse : IErrorResponse<DeleteBalancePlatformsIdTransferLimitsTransferLimitIdError>
{
    public static DeleteBalancePlatformsIdTransferLimitsTransferLimitIdErrorResponse Instance { get; } = new();

    private DeleteBalancePlatformsIdTransferLimitsTransferLimitIdErrorResponse()
    {
    }

    public Task<DeleteBalancePlatformsIdTransferLimitsTransferLimitIdError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        DeleteBalancePlatformsIdTransferLimitsTransferLimitIdError.Create(response, ct);
}
