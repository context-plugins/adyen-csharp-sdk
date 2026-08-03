using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetPublicKeyError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private GetPublicKeyError(Optional<RestServiceError> restServiceErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static GetPublicKeyError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static GetPublicKeyError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) =>
        _restServiceErrorValue.TryGetValue(out value);

    internal static Task<GetPublicKeyError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 422 or 500 => FromJson<RestServiceError>(response, ct).As(AsRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetPublicKeyErrorResponse : IErrorResponse<GetPublicKeyError>
{
    public static GetPublicKeyErrorResponse Instance { get; } = new();

    private GetPublicKeyErrorResponse()
    {
    }

    public Task<GetPublicKeyError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetPublicKeyError.Create(response, ct);
}
