
# VS Code setup guide for C# .NET development

## Required software

* Download [VS Code](https://code.visualstudio.com/download)

* Download [.NET SDK](https://dotnet.microsoft.com/en-us/download)

* Install **C#** extension by **Microsoft** (ID: ms-dotnettools.csharp)  

* (optional) Install **IntelliCode** extension by **Microsoft** (ID: VisualStudioExptTeam.vscodeintellicode)

* (optional) Install **vscode-icons** extension (ID: vscode-icons-team.vscode-icons)

* (optional) Install **GitLens** extension (ID: eamodio.gitlens)

* (optional) Install **NuGet Package Manager** extension (ID: jmrog.vscode-nuget-package-manager)

## Setup of a Console App

* create a new **solution**

      dotnet new sln -n "SOLUTION_NAME"

* create new **Console App project**

      dotnet new console -n "PROJECT_NAME"

* create desired **library projects**

      dotnet new classlib -n "LIBRARY_NAME"

* add each **project** to the **solution**

      dotnet sln SOLUTION_NAME.sln add ./PROJECT_NAME/PROJECT_NAME.csproj

* add references betwen **projects** (if there are any)

      dotnet add PROJECT_NAME/PROJECT_NAME.csproj reference LIBRARY_NAME/LIBRARY_NAME.csproj

 ---

## References

 > [.NET CLI Docs](https://learn.microsoft.com/en-us/dotnet/core/tools/)
