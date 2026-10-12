using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostTransfersTransferIdReturnsError : ApiError
{
    private readonly Optional<TransferServiceRestServiceError> _transferServiceRestServiceErrorValue;

    private PostTransfersTransferIdReturnsError(Optional<TransferServiceRestServiceError> transferServiceRestServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _transferServiceRestServiceErrorValue = transferServiceRestServiceErrorValue;
    }

    private static PostTransfersTransferIdReturnsError AsTransferServiceRestServiceError(TransferServiceRestServiceError value) =>
        new(Optional<TransferServiceRestServiceError>.Some(value), default);

    private static PostTransfersTransferIdReturnsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetTransferServiceRestServiceError(out TransferServiceRestServiceError value) =>
        _transferServiceRestServiceErrorValue.TryGetValue(out value);

    private static Task<PostTransfersTransferIdReturnsError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            401 or 403 or 422 or 500 => response.Json<TransferServiceRestServiceError>().As(
                AsTransferServiceRestServiceError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<PostTransfersTransferIdReturnsError> Response { get; } = new(Create);
}
