# minver-playground
playing with minver

```
dotnet tool install --global minver-cli --version 2.3.1
minver
```

```
md take1
cd take1
dotnet new console
dotnet sln ..\minver-playground.sln add .\take1.csproj
dotnet add package MinVer
dotnet run
```