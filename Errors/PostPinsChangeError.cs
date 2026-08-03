using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostPinsChangeError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private PostPinsChangeError(Optional<RestServiceError> restServiceErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static PostPinsChangeError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static PostPinsChangeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) =>
        _restServiceErrorValue.TryGetValue(out value);

    internal static Task<PostPinsChangeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 422 or 500 => FromJson<RestServiceError>(response, ct).As(AsRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostPinsChangeErrorResponse : IErrorResponse<PostPinsChangeError>
{
    public static PostPinsChangeErrorResponse Instance { get; } = new();

    private PostPinsChangeErrorResponse()
    {
    }

    public Task<PostPinsChangeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostPinsChangeError.Create(response, ct);
}
