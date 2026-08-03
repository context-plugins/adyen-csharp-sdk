using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetGrantOffersIdError : ApiError
{
    private readonly Optional<GrantOffers404Error1> _grantOffers404Error1Value;

    private readonly Optional<GrantOffers422Error31> _grantOffers422Error31Value;

    private GetGrantOffersIdError(Optional<GrantOffers404Error1> grantOffers404Error1Value,
        Optional<GrantOffers422Error31> grantOffers422Error31Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _grantOffers404Error1Value = grantOffers404Error1Value;
        _grantOffers422Error31Value = grantOffers422Error31Value;
    }

    private static GetGrantOffersIdError AsGrantOffers404Error1(GrantOffers404Error1 value) =>
        new(Optional<GrantOffers404Error1>.Some(value), default, default);

    private static GetGrantOffersIdError AsGrantOffers422Error31(GrantOffers422Error31 value) =>
        new(default, Optional<GrantOffers422Error31>.Some(value), default);

    private static GetGrantOffersIdError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetGrantOffers404Error1(out GrantOffers404Error1 value) =>
        _grantOffers404Error1Value.TryGetValue(out value);

    public bool TryGetGrantOffers422Error31(out GrantOffers422Error31 value) =>
        _grantOffers422Error31Value.TryGetValue(out value);

    internal static Task<GetGrantOffersIdError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<GrantOffers404Error1>(response, ct).As(AsGrantOffers404Error1),
            422 => FromJson<GrantOffers422Error31>(response, ct).As(AsGrantOffers422Error31),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetGrantOffersIdErrorResponse : IErrorResponse<GetGrantOffersIdError>
{
    public static GetGrantOffersIdErrorResponse Instance { get; } = new();

    private GetGrantOffersIdErrorResponse()
    {
    }

    public Task<GetGrantOffersIdError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetGrantOffersIdError.Create(response, ct);
}
