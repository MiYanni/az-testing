---
external help file: AppConfiguration-help.xml
Module Name: AppConfiguration
online version: https://docs.microsoft.com/en-us/powershell/module/appconfiguration/get-azconfigurationstorekey
schema: 2.0.0
---

# Get-AzConfigurationStoreKey

## SYNOPSIS
Lists the access key for the specified configuration store.

## SYNTAX

### KeysResourceGroupNameConfigStoreName (Default)
```
Get-AzConfigurationStoreKey -ConfigStoreName <String> [-DefaultProfile <PSObject>] -ResourceGroupName <String>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### KeysSubscriptionIdResourceGroupNameConfigStoreNameSkipToken
```
Get-AzConfigurationStoreKey -ConfigStoreName <String> [-DefaultProfile <PSObject>] -ResourceGroupName <String>
 -SkipToken <String> -SubscriptionId <String> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### KeysResourceGroupNameConfigStoreNameSkipToken
```
Get-AzConfigurationStoreKey -ConfigStoreName <String> [-DefaultProfile <PSObject>] -ResourceGroupName <String>
 -SkipToken <String> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### KeysSubscriptionIdResourceGroupNameConfigStoreName
```
Get-AzConfigurationStoreKey -ConfigStoreName <String> [-DefaultProfile <PSObject>] -ResourceGroupName <String>
 -SubscriptionId <String> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Lists the access key for the specified configuration store.

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -ConfigStoreName
The name of the configuration store.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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

### -ResourceGroupName
The name of the resource group to which the container registry belongs.

```yaml
Type: System.String
Parameter Sets: (All)
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
Parameter Sets: KeysSubscriptionIdResourceGroupNameConfigStoreNameSkipToken, KeysResourceGroupNameConfigStoreNameSkipToken
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
Parameter Sets: KeysSubscriptionIdResourceGroupNameConfigStoreNameSkipToken, KeysSubscriptionIdResourceGroupNameConfigStoreName
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20190201Preview.IApiKey
## NOTES

## RELATED LINKS
