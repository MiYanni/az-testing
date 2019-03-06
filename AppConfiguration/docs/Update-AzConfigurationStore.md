---
external help file: AppConfiguration-help.xml
Module Name: AppConfiguration
online version: https://docs.microsoft.com/en-us/powershell/module/appconfiguration/update-azconfigurationstore
schema: 2.0.0
---

# Update-AzConfigurationStore

## SYNOPSIS
Updates a configuration store with the specified parameters.

## SYNTAX

### ResourceGroupNameConfigStoreNamePropertiesTagsExpanded (Default)
```
Update-AzConfigurationStore [-AsJob] -ConfigStoreName <String> [-DefaultProfile <PSObject>]
 -ResourceGroupName <String> [-ConfigurationStorePropertiesUpdateParametersEnabled] [-Tag <Hashtable>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags
```
Update-AzConfigurationStore [-AsJob] -ConfigStoreName <String>
 -ConfigStoreUpdateParameters <IConfigurationStoreUpdateParameters> [-DefaultProfile <PSObject>]
 -ResourceGroupName <String> -SubscriptionId <String> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ResourceGroupNameConfigStoreNamePropertiesTags
```
Update-AzConfigurationStore [-AsJob] -ConfigStoreName <String>
 -ConfigStoreUpdateParameters <IConfigurationStoreUpdateParameters> [-DefaultProfile <PSObject>]
 -ResourceGroupName <String> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpanded
```
Update-AzConfigurationStore [-AsJob] -ConfigStoreName <String> [-DefaultProfile <PSObject>]
 -ResourceGroupName <String> [-ConfigurationStorePropertiesUpdateParametersEnabled] [-Tag <Hashtable>]
 -SubscriptionId <String> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Updates a configuration store with the specified parameters.

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

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

### -ConfigStoreUpdateParameters
The parameters for updating a configuration store.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20190201Preview.IConfigurationStoreUpdateParameters
Parameter Sets: SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags, ResourceGroupNameConfigStoreNamePropertiesTags
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ConfigurationStorePropertiesUpdateParametersEnabled
The value of this property indicates whether the configuration store endpoint should be enabled to serve requests.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ResourceGroupNameConfigStoreNamePropertiesTagsExpanded, SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpanded
Aliases:

Required: False
Position: Named
Default value: False
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

### -SubscriptionId
The Microsoft Azure subscription ID.

```yaml
Type: System.String
Parameter Sets: SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags, SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tag
The ARM resource tags.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ResourceGroupNameConfigStoreNamePropertiesTagsExpanded, SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpanded
Aliases:

Required: False
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

### Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20190201Preview.IConfigurationStore
## NOTES

## RELATED LINKS
