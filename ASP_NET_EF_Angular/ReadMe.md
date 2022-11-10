
* dotnet --info 
    * .NET SDK (reflecting any global.json)
    *  Runtime Environment:
    * .NET SDKs installed:
    * .NET runtimes installed:

* dotnet -h
  * SDK commands:
  * add               Add a package or reference to a .NET project.
  * build             Build a .NET project.
  * build-server      Interact with servers started by a build.
  * clean             Clean build outputs of a .NET project.
  * format            Apply style preferences to a project or solution.
  * help              Show command line help.
  * list              List project references of a .NET project.
  * msbuild           Run Microsoft Build Engine (MSBuild) commands.
  * new               Create a new .NET project or file.
  * nuget             Provides additional NuGet commands.
  * pack              Create a NuGet package.
  * publish           Publish a .NET project for deployment.
  * remove            Remove a package or reference from a .NET project.
  * restore           Restore dependencies specified in a .NET project.
  * run               Build and run a .NET project output.
  * sdk               Manage .NET SDK installation.
  * sln               Modify Visual Studio solution files.
  * store             Store the specified assemblies in the runtime package store.
  * test              Run unit tests using the test runner specified in a .NET project.
  * tool              Install or manage tools that extend the .NET experience.
  * vstest            Run Microsoft Test Engine (VSTest) commands.
  * workload          Manage optional workloads.


* dotnet new sln
* dotnet new webapi -o API
* dotnet sln add API

* dotnet run --project .\API\API.csproj
* dotnet dev-certs https --trust

* dotnet tool install --global dotnet-ef --version 7.0.0 
* otnet ef database update --project .\API\API.csproj
