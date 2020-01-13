Flurl Http WindowsAuthentication

```csharp
using Flurl.Http.WindowsAuthentication;
```

Setup UseDefaultCredentials for WindowsAuthentication for all requested to defined domain:
```csharp
FlurlConfiguration.ConfigureDomainWithWindowsAuthentication("https://sample.url");
```
or for all request in application:
```csharp
FlurlConfiguration.ConfigureDomainWithWindowsAuthentication();
```

Setup UseDefaultCredentials for WindowsAuthentication only for particular request:
```csharp
var response = await emailServiceUrl
   .AppendPathSegment("email")
   .WithWindowsAuth()
   .GetAsync();
```