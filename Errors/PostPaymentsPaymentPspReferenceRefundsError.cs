using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostPaymentsPaymentPspReferenceRefundsError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private PostPaymentsPaymentPspReferenceRefundsError(Optional<ServiceError> serviceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static PostPaymentsPaymentPspReferenceRefundsError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static PostPaymentsPaymentPspReferenceRefundsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<PostPaymentsPaymentPspReferenceRefundsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostPaymentsPaymentPspReferenceRefundsErrorResponse : IErrorResponse<PostPaymentsPaymentPspReferenceRefundsError>
{
    public static PostPaymentsPaymentPspReferenceRefundsErrorResponse Instance { get; } = new();

    private PostPaymentsPaymentPspReferenceRefundsErrorResponse()
    {
    }

    public Task<PostPaymentsPaymentPspReferenceRefundsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostPaymentsPaymentPspReferenceRefundsError.Create(response, ct);
}
