using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetGrantsGrantIdDisbursementsError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private GetGrantsGrantIdDisbursementsError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static GetGrantsGrantIdDisbursementsError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static GetGrantsGrantIdDisbursementsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<GetGrantsGrantIdDisbursementsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 or 422 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetGrantsGrantIdDisbursementsErrorResponse : IErrorResponse<GetGrantsGrantIdDisbursementsError>
{
    public static GetGrantsGrantIdDisbursementsErrorResponse Instance { get; } = new();

    private GetGrantsGrantIdDisbursementsErrorResponse()
    {
    }

    public Task<GetGrantsGrantIdDisbursementsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetGrantsGrantIdDisbursementsError.Create(response, ct);
}
