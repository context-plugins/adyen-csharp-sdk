using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostDynamicOffersIdGrantOfferError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private PostDynamicOffersIdGrantOfferError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static PostDynamicOffersIdGrantOfferError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static PostDynamicOffersIdGrantOfferError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<PostDynamicOffersIdGrantOfferError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            422 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostDynamicOffersIdGrantOfferErrorResponse : IErrorResponse<PostDynamicOffersIdGrantOfferError>
{
    public static PostDynamicOffersIdGrantOfferErrorResponse Instance { get; } = new();

    private PostDynamicOffersIdGrantOfferErrorResponse()
    {
    }

    public Task<PostDynamicOffersIdGrantOfferError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostDynamicOffersIdGrantOfferError.Create(response, ct);
}
