using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostMergeBalanceError : ApiError
{
    private readonly Optional<ServiceError1> _serviceError1Value;

    private PostMergeBalanceError(Optional<ServiceError1> serviceError1Value, Optional<RawError> fallback) : base(fallback)
    {
        _serviceError1Value = serviceError1Value;
    }

    private static PostMergeBalanceError AsServiceError1(ServiceError1 value) =>
        new(Optional<ServiceError1>.Some(value), default);

    private static PostMergeBalanceError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError1(out ServiceError1 value) => _serviceError1Value.TryGetValue(out value);

    internal static Task<PostMergeBalanceError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 500 => FromJson<ServiceError1>(response, ct).As(AsServiceError1),
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
