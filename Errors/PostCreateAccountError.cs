using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostCreateAccountError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private PostCreateAccountError(Optional<ServiceError> serviceErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static PostCreateAccountError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static PostCreateAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<PostCreateAccountError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostCreateAccountErrorResponse : IErrorResponse<PostCreateAccountError>
{
    public static PostCreateAccountErrorResponse Instance { get; } = new();

    private PostCreateAccountErrorResponse()
    {
    }

    public Task<PostCreateAccountError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostCreateAccountError.Create(response, ct);
}
