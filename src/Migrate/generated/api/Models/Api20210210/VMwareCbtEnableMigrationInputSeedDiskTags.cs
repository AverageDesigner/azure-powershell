namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>The tags for the seed disks.</summary>
    public partial class VMwareCbtEnableMigrationInputSeedDiskTags :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputSeedDiskTags,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMwareCbtEnableMigrationInputSeedDiskTagsInternal
    {

        /// <summary>
        /// Creates an new <see cref="VMwareCbtEnableMigrationInputSeedDiskTags" /> instance.
        /// </summary>
        public VMwareCbtEnableMigrationInputSeedDiskTags()
        {

        }
    }
    /// The tags for the seed disks.
    public partial interface IVMwareCbtEnableMigrationInputSeedDiskTags :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IAssociativeArray<string>
    {

    }
    /// The tags for the seed disks.
    internal partial interface IVMwareCbtEnableMigrationInputSeedDiskTagsInternal

    {

    }
}