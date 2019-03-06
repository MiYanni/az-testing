---
external help file: AppConfiguration-help.xml
Module Name: AppConfiguration
online version: https://docs.microsoft.com/en-us/powershell/module/appconfiguration/test-azconfigurationstorenameavailability
schema: 2.0.0
---

# Test-AzConfigurationStoreNameAvailability

## SYNOPSIS
Checks whether the configuration store name is available for use.

## SYNTAX

### NameAvailabilityNameTypeExpanded (Default)
```
Test-AzConfigurationStoreNameAvailability [-DefaultProfile <PSObject>] -Name <String>
 -Type <ConfigurationResourceType> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### NameAvailabilitySubscriptionIdNameType
```
Test-AzConfigurationStoreNameAvailability -CheckNameAvailabilityParameters <ICheckNameAvailabilityParameters>
 [-DefaultProfile <PSObject>] -SubscriptionId <String> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### NameAvailabilityNameType
```
Test-AzConfigurationStoreNameAvailability -CheckNameAvailabilityParameters <ICheckNameAvailabilityParameters>
 [-DefaultProfile <PSObject>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### NameAvailabilitySubscriptionIdNameTypeExpanded
```
Test-AzConfigurationStoreNameAvailability [-DefaultProfile <PSObject>] -Name <String>
 -Type <ConfigurationResourceType> -SubscriptionId <String> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Checks whether the configuration store name is available for use.

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -CheckNameAvailabilityParameters
Parameters used for checking whether a resource name is available.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20190201Preview.ICheckNameAvailabilityParameters
Parameter Sets: NameAvailabilitySubscriptionIdNameType, NameAvailabilityNameType
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -Name
The name to check for availability.

```yaml
Type: System.String
Parameter Sets: NameAvailabilityNameTypeExpanded, NameAvailabilitySubscriptionIdNameTypeExpanded
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
Parameter Sets: NameAvailabilitySubscriptionIdNameType, NameAvailabilitySubscriptionIdNameTypeExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Type
The resource type to check for name availability.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ConfigurationResourceType
Parameter Sets: NameAvailabilityNameTypeExpanded, NameAvailabilitySubscriptionIdNameTypeExpanded
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

### Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20190201Preview.INameAvailabilityStatus
## NOTES

## RELATED LINKS
