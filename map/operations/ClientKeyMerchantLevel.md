<!-- Generated file — do not edit; regenerated with the SDK. -->

# ClientKeyMerchantLevel — operations

Accessor: `client.ClientKeyMerchantLevel` · Source: `src/Adyen/Api/ClientKeyMerchantLevel.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKey

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKey(PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKeyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `ApiCredentialId`
- **Returns**: `GenerateClientKeyResponse`
- **Error**: `ApiException<PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKeyError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKeyRequest` | `src/Adyen/Requests/ClientKeyMerchantLevel/PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKeyRequest.cs` |
| `GenerateClientKeyResponse` | `src/Adyen/Models/GenerateClientKeyResponse.cs` |
| `PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKeyError` | `src/Adyen/Errors/PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateClientKeyError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

