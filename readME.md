# Flurl Http WindowsAuthentication
  
[![NuGet](https://img.shields.io/nuget/v/Flurl.Http.WindowsAuthentication.svg)](https://www.nuget.org/packages/Flurl.Http.WindowsAuthentication/)  

```csharp
using Flurl.Http.WindowsAuthentication;
```

### Setup UseDefaultCredentials for WindowsAuthentication for all requested to defined domain:
```csharp
FlurlConfiguration.ConfigureDomainWithWindowsAuthentication("https://sample.url");
```

### Setup UseDefaultCredentials for WindowsAuthentication only for particular request:
```csharp
var response = await emailServiceUrl
   .AppendPathSegment("email")
   .WithWindowsAuth()
   .GetAsync();
```
