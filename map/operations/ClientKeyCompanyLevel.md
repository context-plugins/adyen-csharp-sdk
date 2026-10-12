<!-- Generated file — do not edit; regenerated with the SDK. -->

# ClientKeyCompanyLevel — operations

Accessor: `client.ClientKeyCompanyLevel` · Source: `src/Adyen/Api/ClientKeyCompanyLevel.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKey

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKey(PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKeyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `ApiCredentialId`
- **Returns**: `GenerateClientKeyResponse`
- **Error**: `ApiException<PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKeyError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKeyRequest` | `src/Adyen/Requests/ClientKeyCompanyLevel/PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKeyRequest.cs` |
| `GenerateClientKeyResponse` | `src/Adyen/Models/GenerateClientKeyResponse.cs` |
| `PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKeyError` | `src/Adyen/Errors/PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKeyError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

