---
external help file: Microsoft.Azure.PowerShell.Cmdlets.CosmosDB.dll-Help.xml
Module Name: Az.CosmosDB
<<<<<<< HEAD:src/CosmosDB/CosmosDB/help/Invoke-AzCosmosDBCassandraKeyspaceThroughputMigration.md
online version: https://docs.microsoft.com/powershell/module/az.cosmosdb/invoke-azcosmosdbcassandrakeyspacethroughputmigration
=======
online version: https://docs.microsoft.com/en-us/powershell/module/az.cosmosdb/remove-azcosmosdbsqlroleassignment
>>>>>>> 3b23ee907afb52ee1c513e22b27a8d0c5accb859:src/CosmosDB/CosmosDB/help/Remove-AzCosmosDBSqlRoleAssignment.md
schema: 2.0.0
---

# Remove-AzCosmosDBSqlRoleAssignment

## SYNOPSIS
Deletes the CosmosDB Sql Role Assignment.

## SYNTAX

### ByResourceIdParameterSet (Default)
```
Remove-AzCosmosDBSqlRoleAssignment -Id <String> -ResourceGroupName <String> -AccountName <String> [-PassThru]
 [-DefaultProfile <IAzureContextContainer>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ByParentObjectParameterSet
```
Remove-AzCosmosDBSqlRoleAssignment -Id <String> -ParentObject <PSDatabaseAccountGetResults> [-PassThru]
 [-DefaultProfile <IAzureContextContainer>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ByObjectParameterSet
```
Remove-AzCosmosDBSqlRoleAssignment -InputObject <PSSqlRoleAssignmentGetResults> [-PassThru]
 [-DefaultProfile <IAzureContextContainer>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The **Remove-AzCosmosDBSqlRoleAssignment** cmdlet deletes the CosmosDB Sql Role Assignment corresponding to the given ResourceGroupName, AccountName and Id. Id can be either fully qualified or just the Guid.

## EXAMPLES

### Example 1
```powershell
PS C:\> Remove-AzCosmosDBSqlRoleAssignment -ResourceGroupName resourceGroupName -AccountName accountName -Id id -PassThru
true
```

## PARAMETERS

### -AccountName
Name of the Cosmos DB database account.

```yaml
Type: System.String
<<<<<<< HEAD:src/CosmosDB/CosmosDB/help/Invoke-AzCosmosDBCassandraKeyspaceThroughputMigration.md
Parameter Sets: ByNameParameterSet
=======
Parameter Sets: ByResourceIdParameterSet
>>>>>>> 3b23ee907afb52ee1c513e22b27a8d0c5accb859:src/CosmosDB/CosmosDB/help/Remove-AzCosmosDBSqlRoleAssignment.md
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.
<<<<<<< HEAD:src/CosmosDB/CosmosDB/help/Invoke-AzCosmosDBCassandraKeyspaceThroughputMigration.md

```yaml
Type: Microsoft.Azure.Commands.Common.Authentication.Abstractions.Core.IAzureContextContainer
Parameter Sets: (All)
Aliases: AzContext, AzureRmContext, AzureCredential
=======

```yaml
Type: Microsoft.Azure.Commands.Common.Authentication.Abstractions.Core.IAzureContextContainer
Parameter Sets: (All)
Aliases: AzContext, AzureRmContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Role Assignment Id.

```yaml
Type: System.String
Parameter Sets: ByResourceIdParameterSet, ByParentObjectParameterSet
Aliases:
>>>>>>> 3b23ee907afb52ee1c513e22b27a8d0c5accb859:src/CosmosDB/CosmosDB/help/Remove-AzCosmosDBSqlRoleAssignment.md

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Role assignment object.

```yaml
<<<<<<< HEAD:src/CosmosDB/CosmosDB/help/Invoke-AzCosmosDBCassandraKeyspaceThroughputMigration.md
Type: Microsoft.Azure.Commands.CosmosDB.Models.PSCassandraKeyspaceGetResults
=======
Type: Microsoft.Azure.Commands.CosmosDB.Models.PSSqlRoleAssignmentGetResults
>>>>>>> 3b23ee907afb52ee1c513e22b27a8d0c5accb859:src/CosmosDB/CosmosDB/help/Remove-AzCosmosDBSqlRoleAssignment.md
Parameter Sets: ByObjectParameterSet
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ParentObject
CosmosDB Account object

```yaml
<<<<<<< HEAD:src/CosmosDB/CosmosDB/help/Invoke-AzCosmosDBCassandraKeyspaceThroughputMigration.md
Type: System.String
Parameter Sets: (All)
=======
Type: Microsoft.Azure.Commands.CosmosDB.Models.PSDatabaseAccountGetResults
Parameter Sets: ByParentObjectParameterSet
>>>>>>> 3b23ee907afb52ee1c513e22b27a8d0c5accb859:src/CosmosDB/CosmosDB/help/Remove-AzCosmosDBSqlRoleAssignment.md
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PassThru
To be set to true if the user wants to receive an output.
The output is true if the operation was successful and an error is thrown if not.

```yaml
<<<<<<< HEAD:src/CosmosDB/CosmosDB/help/Invoke-AzCosmosDBCassandraKeyspaceThroughputMigration.md
Type: Microsoft.Azure.Commands.CosmosDB.Models.PSDatabaseAccountGetResults
Parameter Sets: ByParentObjectParameterSet
=======
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
>>>>>>> 3b23ee907afb52ee1c513e22b27a8d0c5accb859:src/CosmosDB/CosmosDB/help/Remove-AzCosmosDBSqlRoleAssignment.md
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
Name of resource group.

```yaml
Type: System.String
<<<<<<< HEAD:src/CosmosDB/CosmosDB/help/Invoke-AzCosmosDBCassandraKeyspaceThroughputMigration.md
Parameter Sets: ByNameParameterSet
=======
Parameter Sets: ByResourceIdParameterSet
>>>>>>> 3b23ee907afb52ee1c513e22b27a8d0c5accb859:src/CosmosDB/CosmosDB/help/Remove-AzCosmosDBSqlRoleAssignment.md
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
<<<<<<< HEAD:src/CosmosDB/CosmosDB/help/Invoke-AzCosmosDBCassandraKeyspaceThroughputMigration.md
Type: System.String
=======
Type: System.Management.Automation.SwitchParameter
>>>>>>> 3b23ee907afb52ee1c513e22b27a8d0c5accb859:src/CosmosDB/CosmosDB/help/Remove-AzCosmosDBSqlRoleAssignment.md
Parameter Sets: (All)
Aliases: cf

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
Shows what would happen if the cmdlet runs. The cmdlet is not run.

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

### Microsoft.Azure.Commands.CosmosDB.Models.PSSqlRoleAssignmentGetResults

## OUTPUTS

### System.Void

## NOTES

## RELATED LINKS
