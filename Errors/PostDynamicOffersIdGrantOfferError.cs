using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostDynamicOffersIdGrantOfferError : ApiError
{
    private readonly Optional<DynamicOffersGrantOffer422Error1> _dynamicOffersGrantOffer422Error1Value;

    private PostDynamicOffersIdGrantOfferError(Optional<DynamicOffersGrantOffer422Error1> dynamicOffersGrantOffer422Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _dynamicOffersGrantOffer422Error1Value = dynamicOffersGrantOffer422Error1Value;
    }

    private static PostDynamicOffersIdGrantOfferError AsDynamicOffersGrantOffer422Error1(DynamicOffersGrantOffer422Error1 value) =>
        new(Optional<DynamicOffersGrantOffer422Error1>.Some(value), default);

    private static PostDynamicOffersIdGrantOfferError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDynamicOffersGrantOffer422Error1(out DynamicOffersGrantOffer422Error1 value) =>
        _dynamicOffersGrantOffer422Error1Value.TryGetValue(out value);

    internal static Task<PostDynamicOffersIdGrantOfferError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            422 => FromJson<DynamicOffersGrantOffer422Error1>(response, ct).As(AsDynamicOffersGrantOffer422Error1),
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
