using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostUpdateAccountHolderStateError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private PostUpdateAccountHolderStateError(Optional<ServiceError> serviceErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static PostUpdateAccountHolderStateError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static PostUpdateAccountHolderStateError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<PostUpdateAccountHolderStateError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostUpdateAccountHolderStateErrorResponse : IErrorResponse<PostUpdateAccountHolderStateError>
{
    public static PostUpdateAccountHolderStateErrorResponse Instance { get; } = new();

    private PostUpdateAccountHolderStateErrorResponse()
    {
    }

    public Task<PostUpdateAccountHolderStateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostUpdateAccountHolderStateError.Create(response, ct);
}
