<!-- Generated file — do not edit; regenerated with the SDK. -->

# ApiKeyCompanyLevel — operations

Accessor: `client.ApiKeyCompanyLevel` · Source: `src/Adyen/Api/ApiKeyCompanyLevel.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKey

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKey(PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKeyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `ApiCredentialId`
- **Returns**: `GenerateApiKeyResponse`
- **Error**: `ApiException<PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKeyError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKeyRequest` | `src/Adyen/Requests/ApiKeyCompanyLevel/PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKeyRequest.cs` |
| `GenerateApiKeyResponse` | `src/Adyen/Models/GenerateApiKeyResponse.cs` |
| `PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKeyError` | `src/Adyen/Errors/PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateApiKeyError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

