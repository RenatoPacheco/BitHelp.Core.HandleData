# BitHelp.Core.HandleData

[![Licensed under the MIT License](https://img.shields.io/badge/License-MIT-blue.svg)](./LICENSE)
[![Integration Tests](https://github.com/RenatoPacheco/BitHelp.Core.HandleData/workflows/Integration%20Tests/badge.svg?branch=master)](https://github.com/RenatoPacheco/BitHelp.Core.HandleData/actions/workflows/integration-tests.yml)
[![NuGet](https://img.shields.io/nuget/v/BitHelp.Core.HandleData.svg)](https://nuget.org/packages/BitHelp.Core.HandleData)
[![Nuget](https://img.shields.io/nuget/dt/BitHelp.Core.HandleData.svg)](https://nuget.org/packages/BitHelp.Core.HandleData)

This project contains some classes that allow you to manipulate some data types.

# Getting Started

## Software dependencies

[.NET Standard 2.0](https://docs.microsoft.com/pt-br/dotnet/standard/net-standard)

## Installation process

This package is available through Nuget Packages: https://www.nuget.org/packages/BitHelp.Core.HandleData

**Nuget**
```
Install-Package BitHelp.Core.HandleData
```

**.NET CLI**
```
dotnet add package BitHelp.Core.HandleData
```

## Latest releases

#### Release 0.2.0

**Features:**

- Downgrade the version for netstandard compatibility

To read about others releases access [RELEASES.md](./RELEASES.md)

# Build and Test

Using Visual Studio Code, you can build and test the project from the terminal.

Build and restore the project:

```
dotnet restore
dotnet build --no-restore
```

Tests:

```
dotnet test --no-build --verbosity normal
```