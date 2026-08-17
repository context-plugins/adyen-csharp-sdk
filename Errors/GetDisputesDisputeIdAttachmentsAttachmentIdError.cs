using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetDisputesDisputeIdAttachmentsAttachmentIdError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private GetDisputesDisputeIdAttachmentsAttachmentIdError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static GetDisputesDisputeIdAttachmentsAttachmentIdError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static GetDisputesDisputeIdAttachmentsAttachmentIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<GetDisputesDisputeIdAttachmentsAttachmentIdError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 422 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetDisputesDisputeIdAttachmentsAttachmentIdErrorResponse : IErrorResponse<GetDisputesDisputeIdAttachmentsAttachmentIdError>
{
    public static GetDisputesDisputeIdAttachmentsAttachmentIdErrorResponse Instance { get; } = new();

    private GetDisputesDisputeIdAttachmentsAttachmentIdErrorResponse()
    {
    }

    public Task<GetDisputesDisputeIdAttachmentsAttachmentIdError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetDisputesDisputeIdAttachmentsAttachmentIdError.Create(response, ct);
}
