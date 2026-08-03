using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostPinsRevealError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private PostPinsRevealError(Optional<RestServiceError> restServiceErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static PostPinsRevealError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static PostPinsRevealError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) =>
        _restServiceErrorValue.TryGetValue(out value);

    internal static Task<PostPinsRevealError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 422 or 500 => FromJson<RestServiceError>(response, ct).As(AsRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostPinsRevealErrorResponse : IErrorResponse<PostPinsRevealError>
{
    public static PostPinsRevealErrorResponse Instance { get; } = new();

    private PostPinsRevealErrorResponse()
    {
    }

    public Task<PostPinsRevealError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostPinsRevealError.Create(response, ct);
}
