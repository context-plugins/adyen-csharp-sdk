<!-- Generated file — do not edit; regenerated with the SDK. -->

# BankAccountValidation — operations

Accessor: `client.BankAccountValidation` · Source: `src/Adyen/Api/BankAccountValidation.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostValidateBankAccountIdentification

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostValidateBankAccountIdentification(PostValidateBankAccountIdentificationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `void` (Task)
- **Error**: `ApiException<PostValidateBankAccountIdentificationError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostValidateBankAccountIdentificationRequest` | `src/Adyen/Requests/BankAccountValidation/PostValidateBankAccountIdentificationRequest.cs` |
| `BankAccountIdentificationValidationRequest` | `src/Adyen/Models/BankAccountIdentificationValidationRequest.cs` |
| `PostValidateBankAccountIdentificationError` | `src/Adyen/Errors/PostValidateBankAccountIdentificationError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

