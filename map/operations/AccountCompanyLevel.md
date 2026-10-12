<!-- Generated file — do not edit; regenerated with the SDK. -->

# AccountCompanyLevel — operations

Accessor: `client.AccountCompanyLevel` · Source: `src/Adyen/Api/AccountCompanyLevel.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCompanies

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompanies(GetCompaniesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`
- **Returns**: `ListCompanyResponse`
- **Error**: `ApiException<GetCompaniesError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesRequest` | `src/Adyen/Requests/AccountCompanyLevel/GetCompaniesRequest.cs` |
| `ListCompanyResponse` | `src/Adyen/Models/ListCompanyResponse.cs` |
| `GetCompaniesError` | `src/Adyen/Errors/GetCompaniesError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetCompaniesCompanyId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyId(GetCompaniesCompanyIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Returns**: `Company2`
- **Error**: `ApiException<GetCompaniesCompanyIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdRequest` | `src/Adyen/Requests/AccountCompanyLevel/GetCompaniesCompanyIdRequest.cs` |
| `Company2` | `src/Adyen/Models/Company2.cs` |
| `GetCompaniesCompanyIdError` | `src/Adyen/Errors/GetCompaniesCompanyIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetCompaniesCompanyIdMerchants

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyIdMerchants(GetCompaniesCompanyIdMerchantsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`
- **Returns**: `ListMerchantResponse`
- **Error**: `ApiException<GetCompaniesCompanyIdMerchantsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdMerchantsRequest` | `src/Adyen/Requests/AccountCompanyLevel/GetCompaniesCompanyIdMerchantsRequest.cs` |
| `ListMerchantResponse` | `src/Adyen/Models/ListMerchantResponse.cs` |
| `GetCompaniesCompanyIdMerchantsError` | `src/Adyen/Errors/GetCompaniesCompanyIdMerchantsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

