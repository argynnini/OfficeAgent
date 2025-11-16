# .NET 10.0 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that an .NET 10.0 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET 10.0 upgrade.
3. Upgrade `DesktopAgent.vbproj`

## Settings

### Excluded projects

Table below contains projects that do belong to the dependency graph for selected projects and should not be included in the upgrade.

| Project name                                   | Description                 |
|:-----------------------------------------------|:---------------------------:|


### Aggregate NuGet packages modifications across all projects

NuGet packages used across all selected projects or their dependencies that need version update in projects that reference them.

| Package Name                                     | Current Version | New Version | Description                                   |
|:-------------------------------------------------|:---------------:|:-----------:|:----------------------------------------------|
| Microsoft.Bcl.AsyncInterfaces                    |   7.0.0         | 10.0.0      | Update to match .NET 10 APIs and SDK          |
| Microsoft.Extensions.Configuration               |   7.0.0         | 10.0.0      | Update to supported package for .NET 10       |
| Microsoft.Extensions.Configuration.Abstractions  |   7.0.0         | 10.0.0      | Update to supported package for .NET 10       |
| Microsoft.Extensions.Configuration.Binder        |   7.0.4         | 10.0.0      | Update to supported package for .NET 10       |
| Microsoft.Extensions.DependencyInjection         |   7.0.0         | 10.0.0      | Update to supported package for .NET 10       |
| Microsoft.Extensions.DependencyInjection.Abstractions | 7.0.0      | 10.0.0      | Update to supported package for .NET 10       |
| Microsoft.Extensions.Http                        |   7.0.0         | 10.0.0      | Update to supported package for .NET 10       |
| Microsoft.Extensions.Logging                     |   7.0.0         | 10.0.0      | Update to supported package for .NET 10       |
| Microsoft.Extensions.Logging.Abstractions        |   7.0.1         | 10.0.0      | Update to supported package for .NET 10       |
| Microsoft.Extensions.Options                     |   7.0.1         | 10.0.0      | Update to supported package for .NET 10       |
| Microsoft.Extensions.Primitives                  |   7.0.0         | 10.0.0      | Update to supported package for .NET 10       |
| Newtonsoft.Json                                  |  13.0.3         | 13.0.4      | Patch update recommended                       |
| System.Diagnostics.DiagnosticSource              |   7.0.2         | 10.0.0      | Update to supported package for .NET 10       |
| System.Runtime.CompilerServices.Unsafe           |   6.0.0         |  6.1.2      | Patch update recommended                       |


### Packages provided by new framework (should be removed from PackageReference)

| Package Name                        | Current Version | New Version | Description                                   |
|:------------------------------------|:---------------:|:-----------:|:----------------------------------------------|
| Microsoft.NETCore.Platforms         |   7.0.3         |             | Included in .NET 10 framework reference       |
| Microsoft.Win32.Primitives          |   4.3.0         |             | Included in .NET 10 framework reference       |
| NETStandard.Library                 |   2.0.3         |             | Included in .NET 10 framework reference       |
| System.AppContext                   |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.Buffers                      |   4.5.1         |             | Included in .NET 10 framework reference       |
| System.Collections                  |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.Collections.Concurrent       |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.Console                      |   4.3.1         |             | Included in .NET 10 framework reference       |
| System.Diagnostics.Debug            |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.Diagnostics.Tools            |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.Diagnostics.Tracing          |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.Globalization                |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.Globalization.Calendars      |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.IO                           |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.IO.Compression               |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.IO.Compression.ZipFile       |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.IO.FileSystem                |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.IO.FileSystem.Primitives     |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.Linq                         |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.Linq.Expressions             |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.Memory                       |   4.5.5         |             | Included in .NET 10 framework reference       |
| System.Net.Http                     |   4.3.4         |             | Included in .NET 10 framework reference       |
| System.Net.Primitives               |   4.3.1         |             | Included in .NET 10 framework reference       |
| System.Net.Sockets                  |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.Numerics.Vectors             |   4.5.0         |             | Included in .NET 10 framework reference       |
| System.ObjectModel                  |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.Reflection                   |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.Reflection.Extensions        |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.Reflection.Primitives        |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.Resources.ResourceManager    |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.Runtime                      |   4.3.1         |             | Included in .NET 10 framework reference       |
| System.Runtime.Extensions           |   4.3.1         |             | Included in .NET 10 framework reference       |
| System.Runtime.InteropServices      |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.Runtime.InteropServices.RuntimeInformation | 4.3.0 |           | Included in .NET 10 framework reference       |
| System.Runtime.Numerics             |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.Security.Cryptography.*      |   various       |             | Included in .NET 10 framework reference       |
| System.Text.Encoding                |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.Text.Encoding.Extensions     |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.Text.RegularExpressions      |   4.3.1         |             | Included in .NET 10 framework reference       |
| System.Threading                    |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.Threading.Tasks              |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.Threading.Tasks.Extensions   |   4.5.4         |             | Included in .NET 10 framework reference       |
| System.Threading.Timer              |   4.3.0         |             | Included in .NET 10 framework reference       |
| System.ValueTuple                   |   4.5.0         |             | Included in .NET 10 framework reference       |
| System.Xml.ReaderWriter             |   4.3.1         |             | Included in .NET 10 framework reference       |
| System.Xml.XDocument                |   4.3.0         |             | Included in .NET 10 framework reference       |


### Project upgrade details

#### `DesktopAgent.vbproj` modifications

Project properties changes:
  - Convert project to SDK-style project file.
  - Target framework should be changed from `net48` (NETFramework,Version=v4.8) to `net10.0-windows`.

NuGet packages changes:
  - Update package `Microsoft.Bcl.AsyncInterfaces` from `7.0.0` to `10.0.0`.
  - Update package `Microsoft.Extensions.Configuration` from `7.0.0` to `10.0.0`.
  - Update package `Microsoft.Extensions.Configuration.Abstractions` from `7.0.0` to `10.0.0`.
  - Update package `Microsoft.Extensions.Configuration.Binder` from `7.0.4` to `10.0.0`.
  - Update package `Microsoft.Extensions.DependencyInjection` from `7.0.0` to `10.0.0`.
  - Update package `Microsoft.Extensions.DependencyInjection.Abstractions` from `7.0.0` to `10.0.0`.
  - Update package `Microsoft.Extensions.Http` from `7.0.0` to `10.0.0`.
  - Update package `Microsoft.Extensions.Logging` from `7.0.0` to `10.0.0`.
  - Update package `Microsoft.Extensions.Logging.Abstractions` from `7.0.1` to `10.0.0`.
  - Update package `Microsoft.Extensions.Options` from `7.0.1` to `10.0.0`.
  - Update package `Microsoft.Extensions.Primitives` from `7.0.0` to `10.0.0`.
  - Update package `Newtonsoft.Json` from `13.0.3` to `13.0.4`.
  - Update package `System.Diagnostics.DiagnosticSource` from `7.0.2` to `10.0.0`.
  - Update package `System.Runtime.CompilerServices.Unsafe` from `6.0.0` to `6.1.2`.
  - Remove package references that are provided by the new .NET 10 framework (see list above) instead of PackageReference.

Feature upgrades:
  - Migrate project file to SDK-style and adjust imports and AppDomain or legacy build settings accordingly.
  - Review and update any Windows-specific APIs to the `net10.0-windows` targets if needed.

Other changes:
  - Ensure any binding redirects or assembly resolution settings are removed or converted as appropriate for SDK-style projects.

