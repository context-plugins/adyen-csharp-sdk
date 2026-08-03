using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetDynamicOffersError : ApiError
{
    private readonly Optional<DynamicOffers422Error1> _dynamicOffers422Error1Value;

    private GetDynamicOffersError(Optional<DynamicOffers422Error1> dynamicOffers422Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _dynamicOffers422Error1Value = dynamicOffers422Error1Value;
    }

    private static GetDynamicOffersError AsDynamicOffers422Error1(DynamicOffers422Error1 value) =>
        new(Optional<DynamicOffers422Error1>.Some(value), default);

    private static GetDynamicOffersError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDynamicOffers422Error1(out DynamicOffers422Error1 value) =>
        _dynamicOffers422Error1Value.TryGetValue(out value);

    internal static Task<GetDynamicOffersError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            422 => FromJson<DynamicOffers422Error1>(response, ct).As(AsDynamicOffers422Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetDynamicOffersErrorResponse : IErrorResponse<GetDynamicOffersError>
{
    public static GetDynamicOffersErrorResponse Instance { get; } = new();

    private GetDynamicOffersErrorResponse()
    {
    }

    public Task<GetDynamicOffersError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetDynamicOffersError.Create(response, ct);
}
