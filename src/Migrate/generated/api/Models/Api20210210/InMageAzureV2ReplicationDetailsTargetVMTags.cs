namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>The target VM tags.</summary>
    public partial class InMageAzureV2ReplicationDetailsTargetVMTags :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2ReplicationDetailsTargetVMTags,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2ReplicationDetailsTargetVMTagsInternal
    {

        /// <summary>
        /// Creates an new <see cref="InMageAzureV2ReplicationDetailsTargetVMTags" /> instance.
        /// </summary>
        public InMageAzureV2ReplicationDetailsTargetVMTags()
        {

        }
    }
    /// The target VM tags.
    public partial interface IInMageAzureV2ReplicationDetailsTargetVMTags :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IAssociativeArray<string>
    {

    }
    /// The target VM tags.
    internal partial interface IInMageAzureV2ReplicationDetailsTargetVMTagsInternal

    {

    }
}