<!-- Generated file — do not edit; regenerated with the SDK. -->

# AllowedOriginsCompanyLevel — operations

Accessor: `client.AllowedOriginsCompanyLevel` · Source: `src/Adyen/Api/AllowedOriginsCompanyLevel.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `ApiCredentialId`, `OriginId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest` | `src/Adyen/Requests/AllowedOriginsCompanyLevel/DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest.cs` |
| `DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError` | `src/Adyen/Errors/DeleteCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOrigins

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOrigins(GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `ApiCredentialId`
- **Returns**: `AllowedOriginsResponse`
- **Error**: `ApiException<GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsRequest` | `src/Adyen/Requests/AllowedOriginsCompanyLevel/GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsRequest.cs` |
| `AllowedOriginsResponse` | `src/Adyen/Models/AllowedOriginsResponse.cs` |
| `GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsError` | `src/Adyen/Errors/GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `ApiCredentialId`, `OriginId`
- **Returns**: `AllowedOrigin`
- **Error**: `ApiException<GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest` | `src/Adyen/Requests/AllowedOriginsCompanyLevel/GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdRequest.cs` |
| `AllowedOrigin` | `src/Adyen/Models/AllowedOrigin.cs` |
| `GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError` | `src/Adyen/Errors/GetCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOrigins

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOrigins(PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `ApiCredentialId`
- **Returns**: `AllowedOrigin`
- **Error**: `ApiException<PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsRequest` | `src/Adyen/Requests/AllowedOriginsCompanyLevel/PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsRequest.cs` |
| `AllowedOrigin` | `src/Adyen/Models/AllowedOrigin.cs` |
| `PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsError` | `src/Adyen/Errors/PostCompaniesCompanyIdApiCredentialsApiCredentialIdAllowedOriginsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

