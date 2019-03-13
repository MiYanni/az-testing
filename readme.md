# Az.AppConfiguration Module
> See https://aka.ms/autorest

This is the AutoRest configuration and documentation file for Az.AppConfiguration PowerShell module.

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
Module DLL Loaded [C:\..\AppConfiguration\bin\Az.AppConfiguration.private.dll]
Custom PSM1 Loaded [C:\..\AppConfiguration\custom\Az.AppConfiguration.custom.psm1]
-------------Done-------------
Creating isolated process...
Loaded Module 'Az.Accounts'
Loaded Module 'Az.AppConfiguration'
PS C:\...\AppConfiguration [Az.AppConfiguration]>
```

To examine the cmdlets, use:
> `Get-Command -Module Az.AppConfiguration`

``` text
CommandType     Name                                               Version    Source
-----------     ----                                               -------    ------
Function        Get-AzAppConfigurationStore                        0.1.0      Az.AppConfiguration
Function        Get-AzAppConfigurationStoreKey                     0.1.0      Az.AppConfiguration
Function        New-AzAppConfigurationStore                        0.1.0      Az.AppConfiguration
Function        New-AzAppConfigurationStoreKey                     0.1.0      Az.AppConfiguration
Function        Remove-AzAppConfigurationStore                     0.1.0      Az.AppConfiguration
Function        Test-AzAppConfigurationStoreNameAvailability       0.1.0      Az.AppConfiguration
```

Running a cmdlet:
> `Get-AzAppConfigurationStore`

``` text
Name          Type                                           Id
----          ----                                           --
elkconfigtest Microsoft.AppConfiguration/configurationStores /subscriptions/9e223dbe-3399-4e19-88eb-0975f02ac87f/resourceGroup...
```
---
## Notes about authentication
AutoRest doesn't add authentication code into the generated client. This is handled in Az.Accounts.
The module class alters the HTTP payload before it is sent.

### AutoRest Configuration Information
These are the settings for generating the cmdlets for an API with AutoRest.

``` yaml
input-file: AppConfiguration.json
namespace: Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration
service-name: AppConfiguration
azure: true
powershell: true
output-folder: AppConfiguration
clear-output-folder: true
module-version: 0.1.0
skip-model-cmdlets: true

directive:
  - where:
      noun: ^Configuration(.*)
    set:
      noun: AppConfiguration$1
  - where:
      parameter-name: ConfigStoreName
    set:
      parameter-name: Name
  - where:
      noun: Operation
    set:
      hidden: true
  - where:
      verb: Update
      noun: AppConfigurationStore
    set:
      hidden: true
  - where:
      verb: Get
      variant: (.*)SkipToken$
    set:
      hidden: true
  - where:
      verb: New
      noun: AppConfigurationStore
      variant: ResourceGroupNameConfigStoreNameLocationTagsProperties
    set:
      hidden: true
  - where:
      verb: New
      noun: AppConfigurationStore
      variant: SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsProperties
    set:
      hidden: true
  - where:
      verb: New
      noun: AppConfigurationStoreKey
      variant: KeyResourceGroupNameConfigStoreNameId
    set:
      hidden: true
  - where:
      verb: New
      noun: AppConfigurationStoreKey
      variant: KeySubscriptionIdResourceGroupNameConfigStoreNameId
    set:
      hidden: true
  - where:
      verb: Test
      noun: AppConfigurationStoreNameAvailability
      variant: NameAvailabilityNameType
    set:
      hidden: true
  - where:
      verb: Test
      noun: AppConfigurationStoreNameAvailability
      variant: NameAvailabilitySubscriptionIdNameType
    set:
      hidden: true
```

# PowerShell
This configuration block uses the powershell generator automatically.

``` yaml
use:
- "@microsoft.azure/autorest.powershell@beta"

```
