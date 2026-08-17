using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PatchGrantsGrantIdDisbursementsDisbursementIdError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private PatchGrantsGrantIdDisbursementsDisbursementIdError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static PatchGrantsGrantIdDisbursementsDisbursementIdError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static PatchGrantsGrantIdDisbursementsDisbursementIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<PatchGrantsGrantIdDisbursementsDisbursementIdError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 or 422 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PatchGrantsGrantIdDisbursementsDisbursementIdErrorResponse : IErrorResponse<PatchGrantsGrantIdDisbursementsDisbursementIdError>
{
    public static PatchGrantsGrantIdDisbursementsDisbursementIdErrorResponse Instance { get; } = new();

    private PatchGrantsGrantIdDisbursementsDisbursementIdErrorResponse()
    {
    }

    public Task<PatchGrantsGrantIdDisbursementsDisbursementIdError> Map(HttpResponseMessage response,
        CancellationToken ct) => PatchGrantsGrantIdDisbursementsDisbursementIdError.Create(response, ct);
}
