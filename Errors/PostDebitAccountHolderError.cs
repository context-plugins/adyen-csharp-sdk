using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostDebitAccountHolderError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private PostDebitAccountHolderError(Optional<ServiceError> serviceErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static PostDebitAccountHolderError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static PostDebitAccountHolderError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<PostDebitAccountHolderError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostDebitAccountHolderErrorResponse : IErrorResponse<PostDebitAccountHolderError>
{
    public static PostDebitAccountHolderErrorResponse Instance { get; } = new();

    private PostDebitAccountHolderErrorResponse()
    {
    }

    public Task<PostDebitAccountHolderError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostDebitAccountHolderError.Create(response, ct);
}
