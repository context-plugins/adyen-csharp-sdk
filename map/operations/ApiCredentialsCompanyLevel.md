<!-- Generated file — do not edit; regenerated with the SDK. -->

# ApiCredentialsCompanyLevel — operations

Accessor: `client.ApiCredentialsCompanyLevel` · Source: `src/Adyen/Api/ApiCredentialsCompanyLevel.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCompaniesCompanyIdApiCredentials

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyIdApiCredentials(GetCompaniesCompanyIdApiCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`
- **Returns**: `ListCompanyApiCredentialsResponse`
- **Error**: `ApiException<GetCompaniesCompanyIdApiCredentialsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdApiCredentialsRequest` | `src/Adyen/Requests/ApiCredentialsCompanyLevel/GetCompaniesCompanyIdApiCredentialsRequest.cs` |
| `ListCompanyApiCredentialsResponse` | `src/Adyen/Models/ListCompanyApiCredentialsResponse.cs` |
| `GetCompaniesCompanyIdApiCredentialsError` | `src/Adyen/Errors/GetCompaniesCompanyIdApiCredentialsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetCompaniesCompanyIdApiCredentialsApiCredentialId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyIdApiCredentialsApiCredentialId(GetCompaniesCompanyIdApiCredentialsApiCredentialIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `ApiCredentialId`
- **Returns**: `CompanyApiCredential`
- **Error**: `ApiException<GetCompaniesCompanyIdApiCredentialsApiCredentialIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdApiCredentialsApiCredentialIdRequest` | `src/Adyen/Requests/ApiCredentialsCompanyLevel/GetCompaniesCompanyIdApiCredentialsApiCredentialIdRequest.cs` |
| `CompanyApiCredential` | `src/Adyen/Models/CompanyApiCredential.cs` |
| `GetCompaniesCompanyIdApiCredentialsApiCredentialIdError` | `src/Adyen/Errors/GetCompaniesCompanyIdApiCredentialsApiCredentialIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchCompaniesCompanyIdApiCredentialsApiCredentialId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchCompaniesCompanyIdApiCredentialsApiCredentialId(PatchCompaniesCompanyIdApiCredentialsApiCredentialIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `ApiCredentialId`
- **Returns**: `CompanyApiCredential`
- **Error**: `ApiException<PatchCompaniesCompanyIdApiCredentialsApiCredentialIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchCompaniesCompanyIdApiCredentialsApiCredentialIdRequest` | `src/Adyen/Requests/ApiCredentialsCompanyLevel/PatchCompaniesCompanyIdApiCredentialsApiCredentialIdRequest.cs` |
| `UpdateCompanyApiCredentialRequest` | `src/Adyen/Models/UpdateCompanyApiCredentialRequest.cs` |
| `CompanyApiCredential` | `src/Adyen/Models/CompanyApiCredential.cs` |
| `PatchCompaniesCompanyIdApiCredentialsApiCredentialIdError` | `src/Adyen/Errors/PatchCompaniesCompanyIdApiCredentialsApiCredentialIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostCompaniesCompanyIdApiCredentials

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCompaniesCompanyIdApiCredentials(PostCompaniesCompanyIdApiCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Returns**: `CreateCompanyApiCredentialResponse`
- **Error**: `ApiException<PostCompaniesCompanyIdApiCredentialsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCompaniesCompanyIdApiCredentialsRequest` | `src/Adyen/Requests/ApiCredentialsCompanyLevel/PostCompaniesCompanyIdApiCredentialsRequest.cs` |
| `CreateCompanyApiCredentialRequest` | `src/Adyen/Models/CreateCompanyApiCredentialRequest.cs` |
| `CreateCompanyApiCredentialResponse` | `src/Adyen/Models/CreateCompanyApiCredentialResponse.cs` |
| `PostCompaniesCompanyIdApiCredentialsError` | `src/Adyen/Errors/PostCompaniesCompanyIdApiCredentialsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

