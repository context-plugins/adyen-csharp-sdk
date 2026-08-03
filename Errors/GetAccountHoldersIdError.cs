using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetAccountHoldersIdError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private GetAccountHoldersIdError(Optional<RestServiceError> restServiceErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static GetAccountHoldersIdError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static GetAccountHoldersIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) =>
        _restServiceErrorValue.TryGetValue(out value);

    internal static Task<GetAccountHoldersIdError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<RestServiceError>(response, ct).As(AsRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAccountHoldersIdErrorResponse : IErrorResponse<GetAccountHoldersIdError>
{
    public static GetAccountHoldersIdErrorResponse Instance { get; } = new();

    private GetAccountHoldersIdErrorResponse()
    {
    }

    public Task<GetAccountHoldersIdError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAccountHoldersIdError.Create(response, ct);
}
