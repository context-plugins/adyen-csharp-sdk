using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetDisputesDisputeIdAttachmentsError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private GetDisputesDisputeIdAttachmentsError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static GetDisputesDisputeIdAttachmentsError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static GetDisputesDisputeIdAttachmentsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<GetDisputesDisputeIdAttachmentsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 422 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetDisputesDisputeIdAttachmentsErrorResponse : IErrorResponse<GetDisputesDisputeIdAttachmentsError>
{
    public static GetDisputesDisputeIdAttachmentsErrorResponse Instance { get; } = new();

    private GetDisputesDisputeIdAttachmentsErrorResponse()
    {
    }

    public Task<GetDisputesDisputeIdAttachmentsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetDisputesDisputeIdAttachmentsError.Create(response, ct);
}
