[![Build status](https://ci.appveyor.com/api/projects/status/gh3qq8jf67whuu0d/branch/master?svg=true)](https://ci.appveyor.com/project/ThiagoBarradas/uautil/branch/master)
[![codecov](https://codecov.io/gh/ThiagoBarradas/uautil/branch/master/graph/badge.svg)](https://codecov.io/gh/ThiagoBarradas/uautil)
[![NuGet Downloads](https://img.shields.io/nuget/dt/UAUtil.svg)](https://www.nuget.org/packages/UAUtil/)
[![NuGet Version](https://img.shields.io/nuget/v/UAUtil.svg)](https://www.nuget.org/packages/UAUtil/)

# UAUtil

User-Agent utility - Extract details from user-agent header

## Install via NuGet

```
PM> Install-Package UAUtil
```

## How to use

```csharp
string userAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko";

IUserAgentUtility UAUtil = new UserAgentUtility();

UserAgentDetails userAgentDetails = UAUtil.GetUserAgentDetails(userAgent);

// userAgentDetails.Platform : Desktop
// userAgentDetails.Browser : Internet Explorer
// userAgentDetails.BrowserVersion : 11
// userAgentDetails.OperatingSystem : Windows
// userAgentDetails.OperatingSystemVersion : 10
```

# How can I contribute?
Please, refer to [CONTRIBUTING](CONTRIBUTING.md)

# Found something strange or need a new feature?
Open a new Issue following our issue template [ISSUE-TEMPLATE](ISSUE-TEMPLATE.md)

# Changelog
See in [nuget version history](https://www.nuget.org/packages/UAUtil)

