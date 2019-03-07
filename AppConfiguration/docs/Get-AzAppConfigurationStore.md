---
external help file: Az.AppConfiguration-help.xml
Module Name: Az.AppConfiguration
online version: https://docs.microsoft.com/en-us/powershell/module/az.appconfiguration/get-azappconfigurationstore
schema: 2.0.0
---

# Get-AzAppConfigurationStore

## SYNOPSIS
Lists the configuration stores for a given subscription.

## SYNTAX

### __NoParameters (Default)
```
Get-AzAppConfigurationStore [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### SubscriptionIdResourceGroupNameConfigStoreName
```
Get-AzAppConfigurationStore [-DefaultProfile <PSObject>] -Name <String> -ResourceGroupName <String>
 -SubscriptionId <String> [<CommonParameters>]
```

### ResourceGroupNameConfigStoreName
```
Get-AzAppConfigurationStore [-DefaultProfile <PSObject>] -Name <String> -ResourceGroupName <String>
 [<CommonParameters>]
```

### ResourceGroupSubscriptionIdResourceGroupNameSkipToken
```
Get-AzAppConfigurationStore [-DefaultProfile <PSObject>] -ResourceGroupName <String> -SkipToken <String>
 -SubscriptionId <String> [<CommonParameters>]
```

### ResourceGroupSubscriptionIdResourceGroupName
```
Get-AzAppConfigurationStore [-DefaultProfile <PSObject>] -ResourceGroupName <String> -SubscriptionId <String>
 [<CommonParameters>]
```

### ResourceGroupResourceGroupNameSkipToken
```
Get-AzAppConfigurationStore [-DefaultProfile <PSObject>] -ResourceGroupName <String> -SkipToken <String>
 [<CommonParameters>]
```

### ResourceGroupResourceGroupName
```
Get-AzAppConfigurationStore [-DefaultProfile <PSObject>] -ResourceGroupName <String> [<CommonParameters>]
```

### SubscriptionIdSkipToken
```
Get-AzAppConfigurationStore [-DefaultProfile <PSObject>] -SkipToken <String> -SubscriptionId <String>
 [<CommonParameters>]
```

### SkipToken
```
Get-AzAppConfigurationStore [-DefaultProfile <PSObject>] -SkipToken <String> [<CommonParameters>]
```

### SubscriptionId
```
Get-AzAppConfigurationStore [-DefaultProfile <PSObject>] -SubscriptionId <String> [<CommonParameters>]
```

## DESCRIPTION
Lists the configuration stores for a given subscription.

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The name of the configuration store.

```yaml
Type: System.String
Parameter Sets: SubscriptionIdResourceGroupNameConfigStoreName, ResourceGroupNameConfigStoreName
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group to which the container registry belongs.

```yaml
Type: System.String
Parameter Sets: SubscriptionIdResourceGroupNameConfigStoreName, ResourceGroupNameConfigStoreName, ResourceGroupSubscriptionIdResourceGroupNameSkipToken, ResourceGroupSubscriptionIdResourceGroupName, ResourceGroupResourceGroupNameSkipToken, ResourceGroupResourceGroupName
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SkipToken
A skip token is used to continue retrieving items after an operation returns a partial result.
If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls.

```yaml
Type: System.String
Parameter Sets: ResourceGroupSubscriptionIdResourceGroupNameSkipToken, ResourceGroupResourceGroupNameSkipToken, SubscriptionIdSkipToken, SkipToken
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The Microsoft Azure subscription ID.

```yaml
Type: System.String
Parameter Sets: SubscriptionIdResourceGroupNameConfigStoreName, ResourceGroupSubscriptionIdResourceGroupNameSkipToken, ResourceGroupSubscriptionIdResourceGroupName, SubscriptionIdSkipToken, SubscriptionId
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20190201Preview.IConfigurationStore
## NOTES

## RELATED LINKS
