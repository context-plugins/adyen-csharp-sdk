<!-- Generated file — do not edit; regenerated with the SDK. -->

# PaymentInstrumentGroups — operations

Accessor: `client.PaymentInstrumentGroups` · Source: `src/Adyen/Api/PaymentInstrumentGroups.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetPaymentInstrumentGroupsId

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetPaymentInstrumentGroupsId(GetPaymentInstrumentGroupsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `PaymentInstrumentGroup`
- **Error**: `ApiException<GetPaymentInstrumentGroupsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPaymentInstrumentGroupsIdRequest` | `src/Adyen/Requests/PaymentInstrumentGroups/GetPaymentInstrumentGroupsIdRequest.cs` |
| `PaymentInstrumentGroup` | `src/Adyen/Models/PaymentInstrumentGroup.cs` |
| `GetPaymentInstrumentGroupsIdError` | `src/Adyen/Errors/GetPaymentInstrumentGroupsIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetPaymentInstrumentGroupsIdTransactionRules

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetPaymentInstrumentGroupsIdTransactionRules(GetPaymentInstrumentGroupsIdTransactionRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `TransactionRulesResponse`
- **Error**: `ApiException<GetPaymentInstrumentGroupsIdTransactionRulesError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPaymentInstrumentGroupsIdTransactionRulesRequest` | `src/Adyen/Requests/PaymentInstrumentGroups/GetPaymentInstrumentGroupsIdTransactionRulesRequest.cs` |
| `TransactionRulesResponse` | `src/Adyen/Models/TransactionRulesResponse.cs` |
| `GetPaymentInstrumentGroupsIdTransactionRulesError` | `src/Adyen/Errors/GetPaymentInstrumentGroupsIdTransactionRulesError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostPaymentInstrumentGroups

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostPaymentInstrumentGroups(PostPaymentInstrumentGroupsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `PaymentInstrumentGroup`
- **Error**: `ApiException<PostPaymentInstrumentGroupsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPaymentInstrumentGroupsRequest` | `src/Adyen/Requests/PaymentInstrumentGroups/PostPaymentInstrumentGroupsRequest.cs` |
| `PaymentInstrumentGroupInfo` | `src/Adyen/Models/PaymentInstrumentGroupInfo.cs` |
| `PaymentInstrumentGroup` | `src/Adyen/Models/PaymentInstrumentGroup.cs` |
| `PostPaymentInstrumentGroupsError` | `src/Adyen/Errors/PostPaymentInstrumentGroupsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

