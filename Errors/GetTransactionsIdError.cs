using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetTransactionsIdError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private GetTransactionsIdError(Optional<RestServiceError> restServiceErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static GetTransactionsIdError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static GetTransactionsIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) =>
        _restServiceErrorValue.TryGetValue(out value);

    internal static Task<GetTransactionsIdError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 422 or 500 => FromJson<RestServiceError>(response, ct).As(AsRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetTransactionsIdErrorResponse : IErrorResponse<GetTransactionsIdError>
{
    public static GetTransactionsIdErrorResponse Instance { get; } = new();

    private GetTransactionsIdErrorResponse()
    {
    }

    public Task<GetTransactionsIdError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetTransactionsIdError.Create(response, ct);
}
