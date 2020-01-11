﻿Flurl Http WindowsAuthentication

```
using Flurl.Http.WindowsAuthentication;
```

Setup UseDefaultCredentials for WindowsAuthentication for all requested to defined domain:
```
FlurlConfiguration.ConfigureDomainWithWindowsAuthentication("https://sample.url");
```

Setup UseDefaultCredentials for WindowsAuthentication only for particular request:
```
var response = await emailServiceUrl
   .AppendPathSegment("email")
   .WithWindowsAuth()
   .GetAsync();
```