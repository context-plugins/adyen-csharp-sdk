using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostPaymentsPaymentPspReferenceCancelsError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private PostPaymentsPaymentPspReferenceCancelsError(Optional<ServiceError> serviceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static PostPaymentsPaymentPspReferenceCancelsError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static PostPaymentsPaymentPspReferenceCancelsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<PostPaymentsPaymentPspReferenceCancelsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostPaymentsPaymentPspReferenceCancelsErrorResponse : IErrorResponse<PostPaymentsPaymentPspReferenceCancelsError>
{
    public static PostPaymentsPaymentPspReferenceCancelsErrorResponse Instance { get; } = new();

    private PostPaymentsPaymentPspReferenceCancelsErrorResponse()
    {
    }

    public Task<PostPaymentsPaymentPspReferenceCancelsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostPaymentsPaymentPspReferenceCancelsError.Create(response, ct);
}
