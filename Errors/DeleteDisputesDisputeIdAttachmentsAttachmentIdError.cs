using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class DeleteDisputesDisputeIdAttachmentsAttachmentIdError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private DeleteDisputesDisputeIdAttachmentsAttachmentIdError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static DeleteDisputesDisputeIdAttachmentsAttachmentIdError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static DeleteDisputesDisputeIdAttachmentsAttachmentIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<DeleteDisputesDisputeIdAttachmentsAttachmentIdError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 422 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteDisputesDisputeIdAttachmentsAttachmentIdErrorResponse : IErrorResponse<DeleteDisputesDisputeIdAttachmentsAttachmentIdError>
{
    public static DeleteDisputesDisputeIdAttachmentsAttachmentIdErrorResponse Instance { get; } = new();

    private DeleteDisputesDisputeIdAttachmentsAttachmentIdErrorResponse()
    {
    }

    public Task<DeleteDisputesDisputeIdAttachmentsAttachmentIdError> Map(HttpResponseMessage response,
        CancellationToken ct) => DeleteDisputesDisputeIdAttachmentsAttachmentIdError.Create(response, ct);
}
