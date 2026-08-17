using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostVoidTransactionError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private PostVoidTransactionError(Optional<ServiceError> serviceErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static PostVoidTransactionError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static PostVoidTransactionError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<PostVoidTransactionError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostVoidTransactionErrorResponse : IErrorResponse<PostVoidTransactionError>
{
    public static PostVoidTransactionErrorResponse Instance { get; } = new();

    private PostVoidTransactionErrorResponse()
    {
    }

    public Task<PostVoidTransactionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostVoidTransactionError.Create(response, ct);
}
