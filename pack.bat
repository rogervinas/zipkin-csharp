@echo off

pushd %~dp0

SETLOCAL
SET CACHED_NUGET=%LocalAppData%\NuGet\NuGet.exe

cd src\Zipkin.Core

SET TITLE="Zipkin Core"
SET VERSION=1.0
SET AUTHOR=openzipkin
SET DESCRIPTION="A minimalistic .NET client library for Twitter Zipkin tracing."
SET SUMMARY="Build from fork https://github.com/rogervinas/zipkin-csharp"

%CACHED_NUGET% pack Zipkin.Core.csproj -IncludeReferencedProjects -Properties Configuration=Release;title=%TITLE%;version=%VERSION%;author=%AUTHOR%;description=%DESCRIPTION%;summary=%SUMMARY% -OutputDirectory ..\..

popd
