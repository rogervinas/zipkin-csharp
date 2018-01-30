@echo off

pushd %~dp0

SETLOCAL
SET CACHED_NUGET=%LocalAppData%\NuGet\NuGet.exe

cd src\Zipkin.Core

SET SUMMARY=Zipkin.Core forked to https://github.com/rogervinas/zipkin-csharp

%CACHED_NUGET% pack Zipkin.Core.csproj -OutputDirectory ..\.. -IncludeReferencedProjects -Properties Configuration=Release

popd
