using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostTransfersApproveError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private readonly Optional<TransferServiceRestServiceError> _transferServiceRestServiceErrorValue;

    private PostTransfersApproveError(Optional<ServiceError> serviceErrorValue,
        Optional<TransferServiceRestServiceError> transferServiceRestServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
        _transferServiceRestServiceErrorValue = transferServiceRestServiceErrorValue;
    }

    private static PostTransfersApproveError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default, default);

    private static PostTransfersApproveError AsTransferServiceRestServiceError(TransferServiceRestServiceError value) =>
        new(default, Optional<TransferServiceRestServiceError>.Some(value), default);

    private static PostTransfersApproveError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    public bool TryGetTransferServiceRestServiceError(out TransferServiceRestServiceError value) =>
        _transferServiceRestServiceErrorValue.TryGetValue(out value);

    internal static Task<PostTransfersApproveError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            403 or 422 or 500 => FromJson<TransferServiceRestServiceError>(response, ct).As(AsTransferServiceRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostTransfersApproveErrorResponse : IErrorResponse<PostTransfersApproveError>
{
    public static PostTransfersApproveErrorResponse Instance { get; } = new();

    private PostTransfersApproveErrorResponse()
    {
    }

    public Task<PostTransfersApproveError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostTransfersApproveError.Create(response, ct);
}
