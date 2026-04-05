# Getting Started — .NET / C#

This guide explains how to set up and run the .NET examples in this repository.

---

## Prerequisites

| Requirement | Minimum Version | Download |
|-------------|----------------|---------|
| .NET SDK | 8.0 | [dotnet.microsoft.com](https://dotnet.microsoft.com/download) |
| IDE (optional) | — | [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/) |

Verify your installation:

```bash
dotnet --version
# Expected: 8.0.x or higher
```

---

## Repository Structure

All .NET projects live under `dotnet/DesignPatterns/`. The solution file `DesignPatterns.slnx` at the root of that folder references every project.

```
dotnet/
└── DesignPatterns/
    ├── DesignPatterns.slnx          ← open this in Visual Studio
    ├── CreationalDesignPatterns/
    │   ├── AbstractFactoryDesignPattern/
    │   │   ├── AbstractFactoryDesignPattern.Example1/
    │   │   └── AbstractFactoryDesignPattern.Example2/
    │   └── ...
    ├── StructuralDesignPatterns/
    └── BehavioralDesignPatterns/
```

Each leaf folder (e.g. `AbstractFactoryDesignPattern.Example1`) is a standalone `.csproj` console application.

---

## Running a Single Example

### Option A — .NET CLI (recommended)

```bash
# Navigate to any example folder
cd dotnet/DesignPatterns/CreationalDesignPatterns/AbstractFactoryDesignPattern/AbstractFactoryDesignPattern.Example1

# Run it
dotnet run
```

### Option B — From the solution root

```bash
cd dotnet/DesignPatterns

# Run a specific project by path
dotnet run --project CreationalDesignPatterns/AbstractFactoryDesignPattern/AbstractFactoryDesignPattern.Example1
```

### Option C — Visual Studio

1. Open `dotnet/DesignPatterns/DesignPatterns.slnx` in Visual Studio 2022.
2. In **Solution Explorer**, right-click the project you want to run.
3. Select **Set as Startup Project**.
4. Press **F5** (debug) or **Ctrl+F5** (run without debug).

---

## Building the Entire Solution

```bash
cd dotnet/DesignPatterns
dotnet build
```

To build in **Release** mode:

```bash
dotnet build --configuration Release
```

---

## Running All Examples at Once (PowerShell)

If you want to quickly smoke-test every example, you can use this PowerShell one-liner:

```powershell
Get-ChildItem -Path . -Filter "*.csproj" -Recurse | ForEach-Object {
    Write-Host "`n=== $($_.Directory.Name) ===" -ForegroundColor Cyan
    dotnet run --project $_.FullName
}
```

Run this from the `dotnet/DesignPatterns/` directory.

---

## Troubleshooting

| Problem | Solution |
|---------|----------|
| `dotnet: command not found` | Install the .NET SDK from [dotnet.microsoft.com](https://dotnet.microsoft.com/download) |
| `error MSB1011: Specify which project or solution file to use` | Make sure you are inside a folder that contains a `.csproj` file |
| Build errors after pulling new code | Run `dotnet restore` to restore NuGet packages |

---

## Back to Main README

[← Back to README](../README.md)
