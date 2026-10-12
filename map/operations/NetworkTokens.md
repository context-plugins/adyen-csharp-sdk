<!-- Generated file — do not edit; regenerated with the SDK. -->

# NetworkTokens — operations

Accessor: `client.NetworkTokens` · Source: `src/Adyen/Api/NetworkTokens.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetNetworkTokensNetworkTokenId

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetNetworkTokensNetworkTokenId(GetNetworkTokensNetworkTokenIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `NetworkTokenId`
- **Returns**: `GetNetworkTokenResponse`
- **Error**: `ApiException<GetNetworkTokensNetworkTokenIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetNetworkTokensNetworkTokenIdRequest` | `src/Adyen/Requests/NetworkTokens/GetNetworkTokensNetworkTokenIdRequest.cs` |
| `GetNetworkTokenResponse` | `src/Adyen/Models/GetNetworkTokenResponse.cs` |
| `GetNetworkTokensNetworkTokenIdError` | `src/Adyen/Errors/GetNetworkTokensNetworkTokenIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchNetworkTokensNetworkTokenId

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchNetworkTokensNetworkTokenId(PatchNetworkTokensNetworkTokenIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `NetworkTokenId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<PatchNetworkTokensNetworkTokenIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchNetworkTokensNetworkTokenIdRequest` | `src/Adyen/Requests/NetworkTokens/PatchNetworkTokensNetworkTokenIdRequest.cs` |
| `UpdateNetworkTokenRequest` | `src/Adyen/Models/UpdateNetworkTokenRequest.cs` |
| `PatchNetworkTokensNetworkTokenIdError` | `src/Adyen/Errors/PatchNetworkTokensNetworkTokenIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

