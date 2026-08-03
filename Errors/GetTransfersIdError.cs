using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetTransfersIdError : ApiError
{
    private readonly Optional<TransferServiceRestServiceError> _transferServiceRestServiceErrorValue;

    private GetTransfersIdError(Optional<TransferServiceRestServiceError> transferServiceRestServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _transferServiceRestServiceErrorValue = transferServiceRestServiceErrorValue;
    }

    private static GetTransfersIdError AsTransferServiceRestServiceError(TransferServiceRestServiceError value) =>
        new(Optional<TransferServiceRestServiceError>.Some(value), default);

    private static GetTransfersIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetTransferServiceRestServiceError(out TransferServiceRestServiceError value) =>
        _transferServiceRestServiceErrorValue.TryGetValue(out value);

    internal static Task<GetTransfersIdError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 422 or 500 => FromJson<TransferServiceRestServiceError>(response, ct).As(AsTransferServiceRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetTransfersIdErrorResponse : IErrorResponse<GetTransfersIdError>
{
    public static GetTransfersIdErrorResponse Instance { get; } = new();

    private GetTransfersIdErrorResponse()
    {
    }

    public Task<GetTransfersIdError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetTransfersIdError.Create(response, ct);
}
