---
external help file: Az.AppConfiguration-help.xml
Module Name: Az.AppConfiguration
online version: https://docs.microsoft.com/en-us/powershell/module/az.appconfiguration/new-azappconfigurationstorekey
schema: 2.0.0
---

# New-AzAppConfigurationStoreKey

## SYNOPSIS
Regenerates an access key for the specified configuration store.

## SYNTAX

### KeyResourceGroupNameConfigStoreNameIdExpanded (Default)
```
New-AzAppConfigurationStoreKey -ConfigStoreName <String> [-DefaultProfile <PSObject>]
 -ResourceGroupName <String> [-Id <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### KeySubscriptionIdResourceGroupNameConfigStoreNameId
```
New-AzAppConfigurationStoreKey -ConfigStoreName <String> [-DefaultProfile <PSObject>]
 -RegenerateKeyParameters <IRegenerateKeyParameters> -ResourceGroupName <String> -SubscriptionId <String>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### KeyResourceGroupNameConfigStoreNameId
```
New-AzAppConfigurationStoreKey -ConfigStoreName <String> [-DefaultProfile <PSObject>]
 -RegenerateKeyParameters <IRegenerateKeyParameters> -ResourceGroupName <String> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### KeySubscriptionIdResourceGroupNameConfigStoreNameIdExpanded
```
New-AzAppConfigurationStoreKey -ConfigStoreName <String> [-DefaultProfile <PSObject>]
 -ResourceGroupName <String> [-Id <String>] -SubscriptionId <String> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Regenerates an access key for the specified configuration store.

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

### -Id
The id of the key to regenerate.

```yaml
Type: System.String
Parameter Sets: KeyResourceGroupNameConfigStoreNameIdExpanded, KeySubscriptionIdResourceGroupNameConfigStoreNameIdExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RegenerateKeyParameters
The parameters used to regenerate an API key.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20190201Preview.IRegenerateKeyParameters
Parameter Sets: KeySubscriptionIdResourceGroupNameConfigStoreNameId, KeyResourceGroupNameConfigStoreNameId
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -SubscriptionId
The Microsoft Azure subscription ID.

```yaml
Type: System.String
Parameter Sets: KeySubscriptionIdResourceGroupNameConfigStoreNameId, KeySubscriptionIdResourceGroupNameConfigStoreNameIdExpanded
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