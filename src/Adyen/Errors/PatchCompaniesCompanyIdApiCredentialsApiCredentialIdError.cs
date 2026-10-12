using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PatchCompaniesCompanyIdApiCredentialsApiCredentialIdError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private PatchCompaniesCompanyIdApiCredentialsApiCredentialIdError(Optional<RestServiceError> restServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static PatchCompaniesCompanyIdApiCredentialsApiCredentialIdError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static PatchCompaniesCompanyIdApiCredentialsApiCredentialIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) => _restServiceErrorValue.TryGetValue(out value);

    private static Task<PatchCompaniesCompanyIdApiCredentialsApiCredentialIdError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => response.Json<RestServiceError>().As(AsRestServiceError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<PatchCompaniesCompanyIdApiCredentialsApiCredentialIdError> Response { get; } = new(
        Create);
}
