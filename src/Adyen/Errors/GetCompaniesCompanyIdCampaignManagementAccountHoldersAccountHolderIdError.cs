using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    private static Task<GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => response.Json<DefaultErrorResponseEntity>().As(
                AsDefaultErrorResponseEntity),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError> Response { get; } = new(
        Create);
}
