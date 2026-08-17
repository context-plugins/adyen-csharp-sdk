using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostDisputesDisputeIdAttachmentsError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private PostDisputesDisputeIdAttachmentsError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static PostDisputesDisputeIdAttachmentsError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static PostDisputesDisputeIdAttachmentsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<PostDisputesDisputeIdAttachmentsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 422 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostDisputesDisputeIdAttachmentsErrorResponse : IErrorResponse<PostDisputesDisputeIdAttachmentsError>
{
    public static PostDisputesDisputeIdAttachmentsErrorResponse Instance { get; } = new();

    private PostDisputesDisputeIdAttachmentsErrorResponse()
    {
    }

    public Task<PostDisputesDisputeIdAttachmentsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostDisputesDisputeIdAttachmentsError.Create(response, ct);
}
