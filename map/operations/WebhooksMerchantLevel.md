<!-- Generated file — do not edit; regenerated with the SDK. -->

# WebhooksMerchantLevel — operations

Accessor: `client.WebhooksMerchantLevel` · Source: `src/Adyen/Api/WebhooksMerchantLevel.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteMerchantsMerchantIdWebhooksWebhookId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteMerchantsMerchantIdWebhooksWebhookId(DeleteMerchantsMerchantIdWebhooksWebhookIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `WebhookId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteMerchantsMerchantIdWebhooksWebhookIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteMerchantsMerchantIdWebhooksWebhookIdRequest` | `src/Adyen/Requests/WebhooksMerchantLevel/DeleteMerchantsMerchantIdWebhooksWebhookIdRequest.cs` |
| `DeleteMerchantsMerchantIdWebhooksWebhookIdError` | `src/Adyen/Errors/DeleteMerchantsMerchantIdWebhooksWebhookIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMerchantsMerchantIdWebhooks

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdWebhooks(GetMerchantsMerchantIdWebhooksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`
- **Returns**: `ListWebhooksResponse`
- **Error**: `ApiException<GetMerchantsMerchantIdWebhooksError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdWebhooksRequest` | `src/Adyen/Requests/WebhooksMerchantLevel/GetMerchantsMerchantIdWebhooksRequest.cs` |
| `ListWebhooksResponse` | `src/Adyen/Models/ListWebhooksResponse.cs` |
| `GetMerchantsMerchantIdWebhooksError` | `src/Adyen/Errors/GetMerchantsMerchantIdWebhooksError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMerchantsMerchantIdWebhooksWebhookId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdWebhooksWebhookId(GetMerchantsMerchantIdWebhooksWebhookIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `WebhookId`
- **Returns**: `Webhook`
- **Error**: `ApiException<GetMerchantsMerchantIdWebhooksWebhookIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdWebhooksWebhookIdRequest` | `src/Adyen/Requests/WebhooksMerchantLevel/GetMerchantsMerchantIdWebhooksWebhookIdRequest.cs` |
| `Webhook` | `src/Adyen/Models/Webhook.cs` |
| `GetMerchantsMerchantIdWebhooksWebhookIdError` | `src/Adyen/Errors/GetMerchantsMerchantIdWebhooksWebhookIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchMerchantsMerchantIdWebhooksWebhookId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchMerchantsMerchantIdWebhooksWebhookId(PatchMerchantsMerchantIdWebhooksWebhookIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `WebhookId`
- **Returns**: `Webhook`
- **Error**: `ApiException<PatchMerchantsMerchantIdWebhooksWebhookIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchMerchantsMerchantIdWebhooksWebhookIdRequest` | `src/Adyen/Requests/WebhooksMerchantLevel/PatchMerchantsMerchantIdWebhooksWebhookIdRequest.cs` |
| `UpdateMerchantWebhookRequest` | `src/Adyen/Models/UpdateMerchantWebhookRequest.cs` |
| `Webhook` | `src/Adyen/Models/Webhook.cs` |
| `PatchMerchantsMerchantIdWebhooksWebhookIdError` | `src/Adyen/Errors/PatchMerchantsMerchantIdWebhooksWebhookIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostMerchantsMerchantIdWebhooks

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostMerchantsMerchantIdWebhooks(PostMerchantsMerchantIdWebhooksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `Webhook`
- **Error**: `ApiException<PostMerchantsMerchantIdWebhooksError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMerchantsMerchantIdWebhooksRequest` | `src/Adyen/Requests/WebhooksMerchantLevel/PostMerchantsMerchantIdWebhooksRequest.cs` |
| `CreateMerchantWebhookRequest` | `src/Adyen/Models/CreateMerchantWebhookRequest.cs` |
| `Webhook` | `src/Adyen/Models/Webhook.cs` |
| `PostMerchantsMerchantIdWebhooksError` | `src/Adyen/Errors/PostMerchantsMerchantIdWebhooksError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmac

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmac(PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmacRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `WebhookId`
- **Returns**: `GenerateHmacKeyResponse`
- **Error**: `ApiException<PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmacError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmacRequest` | `src/Adyen/Requests/WebhooksMerchantLevel/PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmacRequest.cs` |
| `GenerateHmacKeyResponse` | `src/Adyen/Models/GenerateHmacKeyResponse.cs` |
| `PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmacError` | `src/Adyen/Errors/PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmacError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostMerchantsMerchantIdWebhooksWebhookIdTest

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostMerchantsMerchantIdWebhooksWebhookIdTest(PostMerchantsMerchantIdWebhooksWebhookIdTestRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `WebhookId`
- **Returns**: `TestWebhookResponse`
- **Error**: `ApiException<PostMerchantsMerchantIdWebhooksWebhookIdTestError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMerchantsMerchantIdWebhooksWebhookIdTestRequest` | `src/Adyen/Requests/WebhooksMerchantLevel/PostMerchantsMerchantIdWebhooksWebhookIdTestRequest.cs` |
| `TestWebhookRequest` | `src/Adyen/Models/TestWebhookRequest.cs` |
| `TestWebhookResponse` | `src/Adyen/Models/TestWebhookResponse.cs` |
| `PostMerchantsMerchantIdWebhooksWebhookIdTestError` | `src/Adyen/Errors/PostMerchantsMerchantIdWebhooksWebhookIdTestError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

