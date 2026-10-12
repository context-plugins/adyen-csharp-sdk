<!-- Generated file — do not edit; regenerated with the SDK. -->

# DonationCampaigns — operations

Accessor: `client.DonationCampaigns` · Source: `src/Adyen/Api/DonationCampaigns.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteCompaniesCompanyIdCampaignManagementDonationCampaignId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteCompaniesCompanyIdCampaignManagementDonationCampaignId(DeleteCompaniesCompanyIdCampaignManagementDonationCampaignIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `DonationCampaignId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteCompaniesCompanyIdCampaignManagementDonationCampaignIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteCompaniesCompanyIdCampaignManagementDonationCampaignIdRequest` | `src/Adyen/Requests/DonationCampaigns/DeleteCompaniesCompanyIdCampaignManagementDonationCampaignIdRequest.cs` |
| `DeleteCompaniesCompanyIdCampaignManagementDonationCampaignIdError` | `src/Adyen/Errors/DeleteCompaniesCompanyIdCampaignManagementDonationCampaignIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderId(GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `AccountHolderId`
- **Query params (wire ← C#)**: `status` ← `Status`, `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`
- **Returns**: `ListDonationCampaignsResponse`
- **Error**: `ApiException<GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdRequest` | `src/Adyen/Requests/DonationCampaigns/GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdRequest.cs` |
| `ListDonationCampaignsResponse` | `src/Adyen/Models/ListDonationCampaignsResponse.cs` |
| `GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError` | `src/Adyen/Errors/GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PatchCompaniesCompanyIdCampaignManagementDonationCampaignId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchCompaniesCompanyIdCampaignManagementDonationCampaignId(PatchCompaniesCompanyIdCampaignManagementDonationCampaignIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `DonationCampaignId`
- **Returns**: `DonationCampaign1`
- **Error**: `ApiException<PatchCompaniesCompanyIdCampaignManagementDonationCampaignIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchCompaniesCompanyIdCampaignManagementDonationCampaignIdRequest` | `src/Adyen/Requests/DonationCampaigns/PatchCompaniesCompanyIdCampaignManagementDonationCampaignIdRequest.cs` |
| `DonationCampaignUpdate` | `src/Adyen/Models/DonationCampaignUpdate.cs` |
| `DonationCampaign1` | `src/Adyen/Models/DonationCampaign1.cs` |
| `PatchCompaniesCompanyIdCampaignManagementDonationCampaignIdError` | `src/Adyen/Errors/PatchCompaniesCompanyIdCampaignManagementDonationCampaignIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostCompaniesCompanyIdCampaignManagement

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCompaniesCompanyIdCampaignManagement(PostCompaniesCompanyIdCampaignManagementRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Returns**: `DonationCampaign1`
- **Error**: `ApiException<PostCompaniesCompanyIdCampaignManagementError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCompaniesCompanyIdCampaignManagementRequest` | `src/Adyen/Requests/DonationCampaigns/PostCompaniesCompanyIdCampaignManagementRequest.cs` |
| `DonationCampaignRequest` | `src/Adyen/Models/DonationCampaignRequest.cs` |
| `DonationCampaign1` | `src/Adyen/Models/DonationCampaign1.cs` |
| `PostCompaniesCompanyIdCampaignManagementError` | `src/Adyen/Errors/PostCompaniesCompanyIdCampaignManagementError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatus

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatus(PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `DonationCampaignId`, `Status`
- **Returns**: `DonationCampaign1`
- **Error**: `ApiException<PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusRequest` | `src/Adyen/Requests/DonationCampaigns/PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusRequest.cs` |
| `CampaignStatusTransition` | `src/Adyen/Models/Enums/CampaignStatusTransition.cs` |
| `DonationCampaign1` | `src/Adyen/Models/DonationCampaign1.cs` |
| `PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError` | `src/Adyen/Errors/PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostCompaniesCompanyIdNonprofits

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCompaniesCompanyIdNonprofits(PostCompaniesCompanyIdNonprofitsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Query params (wire ← C#)**: `searchTerm` ← `SearchTerm`, `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`, `goal` ← `Goal`
- **Returns**: `ListNonprofitsResponse`
- **Error**: `ApiException<PostCompaniesCompanyIdNonprofitsError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCompaniesCompanyIdNonprofitsRequest` | `src/Adyen/Requests/DonationCampaigns/PostCompaniesCompanyIdNonprofitsRequest.cs` |
| `ListNonprofitsRequest` | `src/Adyen/Models/ListNonprofitsRequest.cs` |
| `ListNonprofitsResponse` | `src/Adyen/Models/ListNonprofitsResponse.cs` |
| `PostCompaniesCompanyIdNonprofitsError` | `src/Adyen/Errors/PostCompaniesCompanyIdNonprofitsError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

