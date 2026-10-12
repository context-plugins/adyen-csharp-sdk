using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostTransfersApproveError : ApiError
{
    private readonly Optional<ServiceError1> _serviceError1Value;

    private readonly Optional<TransferServiceRestServiceError> _transferServiceRestServiceErrorValue;

    private PostTransfersApproveError(Optional<ServiceError1> serviceError1Value,
        Optional<TransferServiceRestServiceError> transferServiceRestServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _serviceError1Value = serviceError1Value;
        _transferServiceRestServiceErrorValue = transferServiceRestServiceErrorValue;
    }

    private static PostTransfersApproveError AsServiceError1(ServiceError1 value) =>
        new(Optional<ServiceError1>.Some(value), default, default);

    private static PostTransfersApproveError AsTransferServiceRestServiceError(TransferServiceRestServiceError value) =>
        new(default, Optional<TransferServiceRestServiceError>.Some(value), default);

    private static PostTransfersApproveError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetServiceError1(out ServiceError1 value) => _serviceError1Value.TryGetValue(out value);

    public bool TryGetTransferServiceRestServiceError(out TransferServiceRestServiceError value) =>
        _transferServiceRestServiceErrorValue.TryGetValue(out value);

    private static Task<PostTransfersApproveError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            401 => response.Json<ServiceError1>().As(AsServiceError1),
            403 or 422 or 500 => response.Json<TransferServiceRestServiceError>().As(AsTransferServiceRestServiceError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<PostTransfersApproveError> Response { get; } = new(Create);
}
