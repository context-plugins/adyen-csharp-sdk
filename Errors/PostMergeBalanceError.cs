using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostMergeBalanceError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private PostMergeBalanceError(Optional<ServiceError> serviceErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static PostMergeBalanceError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static PostMergeBalanceError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<PostMergeBalanceError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostMergeBalanceErrorResponse : IErrorResponse<PostMergeBalanceError>
{
    public static PostMergeBalanceErrorResponse Instance { get; } = new();

    private PostMergeBalanceErrorResponse()
    {
    }

    public Task<PostMergeBalanceError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostMergeBalanceError.Create(response, ct);
}
