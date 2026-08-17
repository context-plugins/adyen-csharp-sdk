using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetGrantsGrantIdDisbursementsDisbursementIdError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private GetGrantsGrantIdDisbursementsDisbursementIdError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static GetGrantsGrantIdDisbursementsDisbursementIdError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static GetGrantsGrantIdDisbursementsDisbursementIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<GetGrantsGrantIdDisbursementsDisbursementIdError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 or 422 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetGrantsGrantIdDisbursementsDisbursementIdErrorResponse : IErrorResponse<GetGrantsGrantIdDisbursementsDisbursementIdError>
{
    public static GetGrantsGrantIdDisbursementsDisbursementIdErrorResponse Instance { get; } = new();

    private GetGrantsGrantIdDisbursementsDisbursementIdErrorResponse()
    {
    }

    public Task<GetGrantsGrantIdDisbursementsDisbursementIdError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetGrantsGrantIdDisbursementsDisbursementIdError.Create(response, ct);
}
