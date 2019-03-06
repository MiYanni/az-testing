# AppConfiguration Module
> See https://aka.ms/autorest

This is the AutoRest configuration and documentation file for AppConfiguration PowerShell module.

---
## Requirements to build the module
Use of the beta version of `autorest.powershell` generator requires the following:
- [NodeJS LTS](https://nodejs.org) (10.15.x LTS preferred)
  - **Note**: It *will not work* with Node < 10.x. Using 11.x builds may cause issues as they may introduce instability or breaking changes.
> If you want an easy way to install and update Node, [NVS - Node Version Switcher](../nodejs/installing-via-nvs.md) or [NVM - Node Version Manager](../nodejs/installing-via-nvm.md) is recommended.
- [AutoRest](https://aka.ms/autorest) v3 beta <br> `npm install -g autorest@beta ` <br>&nbsp;
- PowerShell 6.0 or greater
  - If you don't have it installed, you can use the cross-platform npm package <br> `npm install -g pwsh` <br>&nbsp;
- .NET Core SDK 2.0 or greater
  - If you don't have it installed, you can use the cross-platform npm package <br> `npm install -g dotnet-sdk-2.2 ` <br>&nbsp;

## Requirements to use the module
- [Az.Accounts module](https://www.powershellgallery.com/packages/Az.Accounts/), version 1.4.0 or greater

# Regenerating the module from Swagger
In this directory, run AutoRest:
> `autorest`

## Running the module 
To compile and run the module, use:
> `./AppConfiguration/build-module.ps1 -Run`

``` text
Creating isolated process...
Cleaning build folders...
Compiling module...
Module DLL Loaded [C:\CodeTemp\AppConfiguration\AppConfiguration\bin\AppConfiguration.private.dll]
Custom PSM1 Loaded [C:\CodeTemp\AppConfiguration\AppConfiguration\custom\AppConfiguration.custom.psm1]
-------------Done-------------
Creating isolated process...
Loaded Module 'Az.Accounts'
Loaded Module 'AppConfiguration'
PS C:\...\AppConfiguration [AppConfiguration]>
```

To examine the cmdlets, use:
> `Get-Command -Module AppConfiguration`

``` text
CommandType     Name                                               Version    Source
-----------     ----                                               -------    ------
Function        Get-AzConfigurationStore                           1.0        AppConfiguration
Function        Get-AzConfigurationStoreKey                        1.0        AppConfiguration
Function        New-AzConfigurationStore                           1.0        AppConfiguration
Function        New-AzConfigurationStoreKey                        1.0        AppConfiguration
Function        Remove-AzConfigurationStore                        1.0        AppConfiguration
Function        Test-AzConfigurationStoreNameAvailability          1.0        AppConfiguration
Function        Update-AzConfigurationStore                        1.0        AppConfiguration
```

Running a cmdlet:
> `Get-AzConfigurationStore`

``` text
Name          Type                                           Id
----          ----                                           --
elkconfigtest Microsoft.AppConfiguration/configurationStores /subscriptions/9e223dbe-3399-4e19-88eb-0975f02ac87f/resourceGroup...
```
---
## Notes about authentication
AutoRest doesn't add authentication code into the generated client. This is handled in Az.Accounts.

This sample includes an [extension](./AppConfiguration/generated/Module.cs) to the module that alters the HTTP payload before it is sent.

### AutoRest Configuration Information
These are the settings for generating the cmdlets for an API with AutoRest.

``` yaml
input-file: AppConfiguration.json
namespace: Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration
title: AppConfiguration
powershell: true
clear-output-folder: true
output-folder: AppConfiguration
azure: true
skip-model-cmdlets: true

directive:
- remove-operation: Operations_List
```

# PowerShell
This configuration block uses the powershell generator automatically.

``` yaml
use:
- "@microsoft.azure/autorest.powershell@beta"

```
