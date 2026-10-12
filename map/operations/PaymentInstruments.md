<!-- Generated file — do not edit; regenerated with the SDK. -->

# PaymentInstruments — operations

Accessor: `client.PaymentInstruments` · Source: `src/Adyen/Api/PaymentInstruments.cs` · 9 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetPaymentInstrumentsId

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetPaymentInstrumentsId(GetPaymentInstrumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `PaymentInstrument1`
- **Error**: `ApiException<GetPaymentInstrumentsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPaymentInstrumentsIdRequest` | `src/Adyen/Requests/PaymentInstruments/GetPaymentInstrumentsIdRequest.cs` |
| `PaymentInstrument1` | `src/Adyen/Models/PaymentInstrument1.cs` |
| `GetPaymentInstrumentsIdError` | `src/Adyen/Errors/GetPaymentInstrumentsIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetPaymentInstrumentsIdNetworkTokenActivationData

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetPaymentInstrumentsIdNetworkTokenActivationData(GetPaymentInstrumentsIdNetworkTokenActivationDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `NetworkTokenActivationDataResponse`
- **Error**: `ApiException<GetPaymentInstrumentsIdNetworkTokenActivationDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPaymentInstrumentsIdNetworkTokenActivationDataRequest` | `src/Adyen/Requests/PaymentInstruments/GetPaymentInstrumentsIdNetworkTokenActivationDataRequest.cs` |
| `NetworkTokenActivationDataResponse` | `src/Adyen/Models/NetworkTokenActivationDataResponse.cs` |
| `GetPaymentInstrumentsIdNetworkTokenActivationDataError` | `src/Adyen/Errors/GetPaymentInstrumentsIdNetworkTokenActivationDataError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetPaymentInstrumentsIdNetworkTokens

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetPaymentInstrumentsIdNetworkTokens(GetPaymentInstrumentsIdNetworkTokensRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `ListNetworkTokensResponse`
- **Error**: `ApiException<GetPaymentInstrumentsIdNetworkTokensError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPaymentInstrumentsIdNetworkTokensRequest` | `src/Adyen/Requests/PaymentInstruments/GetPaymentInstrumentsIdNetworkTokensRequest.cs` |
| `ListNetworkTokensResponse` | `src/Adyen/Models/ListNetworkTokensResponse.cs` |
| `GetPaymentInstrumentsIdNetworkTokensError` | `src/Adyen/Errors/GetPaymentInstrumentsIdNetworkTokensError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetPaymentInstrumentsIdReveal

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetPaymentInstrumentsIdReveal(GetPaymentInstrumentsIdRevealRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `PaymentInstrumentRevealInfo`
- **Error**: `ApiException<GetPaymentInstrumentsIdRevealError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPaymentInstrumentsIdRevealRequest` | `src/Adyen/Requests/PaymentInstruments/GetPaymentInstrumentsIdRevealRequest.cs` |
| `PaymentInstrumentRevealInfo` | `src/Adyen/Models/PaymentInstrumentRevealInfo.cs` |
| `GetPaymentInstrumentsIdRevealError` | `src/Adyen/Errors/GetPaymentInstrumentsIdRevealError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetPaymentInstrumentsIdTransactionRules

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetPaymentInstrumentsIdTransactionRules(GetPaymentInstrumentsIdTransactionRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `TransactionRulesResponse`
- **Error**: `ApiException<GetPaymentInstrumentsIdTransactionRulesError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPaymentInstrumentsIdTransactionRulesRequest` | `src/Adyen/Requests/PaymentInstruments/GetPaymentInstrumentsIdTransactionRulesRequest.cs` |
| `TransactionRulesResponse` | `src/Adyen/Models/TransactionRulesResponse.cs` |
| `GetPaymentInstrumentsIdTransactionRulesError` | `src/Adyen/Errors/GetPaymentInstrumentsIdTransactionRulesError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchPaymentInstrumentsId

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchPaymentInstrumentsId(PatchPaymentInstrumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `UpdatePaymentInstrument`
- **Error**: `ApiException<PatchPaymentInstrumentsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchPaymentInstrumentsIdRequest` | `src/Adyen/Requests/PaymentInstruments/PatchPaymentInstrumentsIdRequest.cs` |
| `PaymentInstrumentUpdateRequest` | `src/Adyen/Models/PaymentInstrumentUpdateRequest.cs` |
| `UpdatePaymentInstrument` | `src/Adyen/Models/UpdatePaymentInstrument.cs` |
| `PatchPaymentInstrumentsIdError` | `src/Adyen/Errors/PatchPaymentInstrumentsIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostPaymentInstruments

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostPaymentInstruments(PostPaymentInstrumentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `PaymentInstrument1`
- **Error**: `ApiException<PostPaymentInstrumentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPaymentInstrumentsRequest` | `src/Adyen/Requests/PaymentInstruments/PostPaymentInstrumentsRequest.cs` |
| `PaymentInstrumentInfo` | `src/Adyen/Models/PaymentInstrumentInfo.cs` |
| `PaymentInstrument1` | `src/Adyen/Models/PaymentInstrument1.cs` |
| `PostPaymentInstrumentsError` | `src/Adyen/Errors/PostPaymentInstrumentsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostPaymentInstrumentsIdNetworkTokenActivationData

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostPaymentInstrumentsIdNetworkTokenActivationData(PostPaymentInstrumentsIdNetworkTokenActivationDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `NetworkTokenActivationDataResponse`
- **Error**: `ApiException<PostPaymentInstrumentsIdNetworkTokenActivationDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPaymentInstrumentsIdNetworkTokenActivationDataRequest` | `src/Adyen/Requests/PaymentInstruments/PostPaymentInstrumentsIdNetworkTokenActivationDataRequest.cs` |
| `NetworkTokenActivationDataRequest` | `src/Adyen/Models/NetworkTokenActivationDataRequest.cs` |
| `NetworkTokenActivationDataResponse` | `src/Adyen/Models/NetworkTokenActivationDataResponse.cs` |
| `PostPaymentInstrumentsIdNetworkTokenActivationDataError` | `src/Adyen/Errors/PostPaymentInstrumentsIdNetworkTokenActivationDataError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostPaymentInstrumentsReveal

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostPaymentInstrumentsReveal(PostPaymentInstrumentsRevealRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `PaymentInstrumentRevealResponse`
- **Error**: `ApiException<PostPaymentInstrumentsRevealError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPaymentInstrumentsRevealRequest` | `src/Adyen/Requests/PaymentInstruments/PostPaymentInstrumentsRevealRequest.cs` |
| `PaymentInstrumentRevealRequest` | `src/Adyen/Models/PaymentInstrumentRevealRequest.cs` |
| `PaymentInstrumentRevealResponse` | `src/Adyen/Models/PaymentInstrumentRevealResponse.cs` |
| `PostPaymentInstrumentsRevealError` | `src/Adyen/Errors/PostPaymentInstrumentsRevealError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

