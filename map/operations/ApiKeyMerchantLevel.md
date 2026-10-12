<!-- Generated file — do not edit; regenerated with the SDK. -->

# ApiKeyMerchantLevel — operations

Accessor: `client.ApiKeyMerchantLevel` · Source: `src/Adyen/Api/ApiKeyMerchantLevel.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKey

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKey(PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKeyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `ApiCredentialId`
- **Returns**: `GenerateApiKeyResponse`
- **Error**: `ApiException<PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKeyError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKeyRequest` | `src/Adyen/Requests/ApiKeyMerchantLevel/PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKeyRequest.cs` |
| `GenerateApiKeyResponse` | `src/Adyen/Models/GenerateApiKeyResponse.cs` |
| `PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKeyError` | `src/Adyen/Errors/PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKeyError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

