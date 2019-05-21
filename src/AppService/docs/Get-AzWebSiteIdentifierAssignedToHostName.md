---
external help file: Az.WebSite-help.xml
Module Name: Az.WebSite
online version: https://docs.microsoft.com/en-us/powershell/module/az.website/get-azwebsiteidentifierassignedtohostname
schema: 2.0.0
---

# Get-AzWebSiteIdentifierAssignedToHostName

## SYNOPSIS
List all apps that are assigned to a hostname.

## SYNTAX

### List1 (Default)
```
Get-AzWebSiteIdentifierAssignedToHostName -SubscriptionId <String[]> [-NameIdentifier <INameIdentifier>]
 [-DefaultProfile <PSObject>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ListExpanded1
```
Get-AzWebSiteIdentifierAssignedToHostName -SubscriptionId <String[]> [-Name <String>]
 [-DefaultProfile <PSObject>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
List all apps that are assigned to a hostname.

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
Name of the object.

```yaml
Type: System.String
Parameter Sets: ListExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NameIdentifier
Identifies an object.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.WebSite.Models.Api20160301.INameIdentifier
Parameter Sets: List1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SubscriptionId
Your Azure subscription ID.
This is a GUID-formatted string (e.g.
00000000-0000-0000-0000-000000000000).

```yaml
Type: System.String[]
Parameter Sets: (All)
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
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.WebSite.Models.Api20160301.IIdentifier
## NOTES

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/az.website/get-azwebsiteidentifierassignedtohostname](https://docs.microsoft.com/en-us/powershell/module/az.website/get-azwebsiteidentifierassignedtohostname)
