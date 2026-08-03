using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostDynamicOffersIdCalculateError : ApiError
{
    private readonly Optional<DynamicOffersCalculate422Error1> _dynamicOffersCalculate422Error1Value;

    private PostDynamicOffersIdCalculateError(Optional<DynamicOffersCalculate422Error1> dynamicOffersCalculate422Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _dynamicOffersCalculate422Error1Value = dynamicOffersCalculate422Error1Value;
    }

    private static PostDynamicOffersIdCalculateError AsDynamicOffersCalculate422Error1(DynamicOffersCalculate422Error1 value) =>
        new(Optional<DynamicOffersCalculate422Error1>.Some(value), default);

    private static PostDynamicOffersIdCalculateError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDynamicOffersCalculate422Error1(out DynamicOffersCalculate422Error1 value) =>
        _dynamicOffersCalculate422Error1Value.TryGetValue(out value);

    internal static Task<PostDynamicOffersIdCalculateError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            422 => FromJson<DynamicOffersCalculate422Error1>(response, ct).As(AsDynamicOffersCalculate422Error1),
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
