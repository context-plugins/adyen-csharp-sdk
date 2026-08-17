using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 404 or 422 or 500 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdErrorResponse : IErrorResponse<GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError>
{
    public static GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdErrorResponse Instance { get; } = new();

    private GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdErrorResponse()
    {
    }

    public Task<GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError.Create(response, ct);
}
