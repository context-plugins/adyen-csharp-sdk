using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostDynamicOffersIdCalculateError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private PostDynamicOffersIdCalculateError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static PostDynamicOffersIdCalculateError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static PostDynamicOffersIdCalculateError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<PostDynamicOffersIdCalculateError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            422 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostDynamicOffersIdCalculateErrorResponse : IErrorResponse<PostDynamicOffersIdCalculateError>
{
    public static PostDynamicOffersIdCalculateErrorResponse Instance { get; } = new();

    private PostDynamicOffersIdCalculateErrorResponse()
    {
    }

    public Task<PostDynamicOffersIdCalculateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostDynamicOffersIdCalculateError.Create(response, ct);
}
