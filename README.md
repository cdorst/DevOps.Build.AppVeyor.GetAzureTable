# DevOps.Build.AppVeyor.GetAzureTable

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-build-appveyor-getazuretable.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/devops-build-appveyor-getazuretable)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Build.AppVeyor.GetAzureTable.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.GetAzureTable)

## Description

Function returns an Azure CloudTable reference for a table named appveyor

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[CDorst.Azure.Storage.Table.GetAzureTable](https://github.com/CDorst/Azure.Storage.Table.GetAzureTable) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/azure-storage-table-getazuretable.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/azure-storage-table-getazuretable) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Azure.Storage.Table.GetAzureTable.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Azure.Storage.Table.GetAzureTable)
[CDorst.DevOps.Build.AppVeyor.AzureStorageTableLedger](https://github.com/CDorst/DevOps.Build.AppVeyor.AzureStorageTableLedger) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-build-appveyor-azurestoragetableledger.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-build-appveyor-azurestoragetableledger) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Build.AppVeyor.AzureStorageTableLedger.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.AzureStorageTableLedger)

## Dependents

The projects below use this repository as a direct dependency.

Name | Status
---- | ------
[DevOps.Build.AppVeyor.AddBuild](https://github.com/CDorst/DevOps.Build.AppVeyor.AddBuild) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-build-appveyor-addbuild.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-build-appveyor-addbuild) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Build.AppVeyor.AddBuild.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.AddBuild)
[DevOps.Build.AppVeyor.GetBuildRecord](https://github.com/CDorst/DevOps.Build.AppVeyor.GetBuildRecord) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-build-appveyor-getbuildrecord.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-build-appveyor-getbuildrecord) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Build.AppVeyor.GetBuildRecord.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.GetBuildRecord)
[DevOps.Build.AppVeyor.AddRepositoryVersion](https://github.com/CDorst/DevOps.Build.AppVeyor.AddRepositoryVersion) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-build-appveyor-addrepositoryversion.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-build-appveyor-addrepositoryversion) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Build.AppVeyor.AddRepositoryVersion.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.AddRepositoryVersion)
[DevOps.Build.AppVeyor.GetRepositoryVersionRecord](https://github.com/CDorst/DevOps.Build.AppVeyor.GetRepositoryVersionRecord) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-build-appveyor-getrepositoryversionrecord.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-build-appveyor-getrepositoryversionrecord) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Build.AppVeyor.GetRepositoryVersionRecord.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.GetRepositoryVersionRecord)

## NuGet


This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.GetAzureTable](https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.GetAzureTable)

## Version

1.0.10

## Metaproject

DevOps.Build.AppVeyor.GetAzureTable is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

