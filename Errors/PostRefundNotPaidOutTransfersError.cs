using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostRefundNotPaidOutTransfersError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private PostRefundNotPaidOutTransfersError(Optional<ServiceError> serviceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static PostRefundNotPaidOutTransfersError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static PostRefundNotPaidOutTransfersError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<PostRefundNotPaidOutTransfersError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostRefundNotPaidOutTransfersErrorResponse : IErrorResponse<PostRefundNotPaidOutTransfersError>
{
    public static PostRefundNotPaidOutTransfersErrorResponse Instance { get; } = new();

    private PostRefundNotPaidOutTransfersErrorResponse()
    {
    }

    public Task<PostRefundNotPaidOutTransfersError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostRefundNotPaidOutTransfersError.Create(response, ct);
}
