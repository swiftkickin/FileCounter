# File Counter

I needed a simple .NET Core application for some samples, and this is it.  If you run FileCounter, it'll count all the files in the current directory and inner directories.

## To build
```
dotnet publish -c Release -r win-x64 --self-contained -o publish
```