namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Hyper-V Managed disk details.</summary>
    public partial class HyperVReplicaAzureManagedDiskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureManagedDiskDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureManagedDiskDetailsInternal
    {

        /// <summary>Backing field for <see cref="DiskEncryptionSetId" /> property.</summary>
        private string _diskEncryptionSetId;

        /// <summary>The disk encryption set ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskEncryptionSetId { get => this._diskEncryptionSetId; set => this._diskEncryptionSetId = value; }

        /// <summary>Backing field for <see cref="DiskId" /> property.</summary>
        private string _diskId;

        /// <summary>The disk Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskId { get => this._diskId; set => this._diskId = value; }

        /// <summary>Backing field for <see cref="ReplicaDiskType" /> property.</summary>
        private string _replicaDiskType;

        /// <summary>The replica disk type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ReplicaDiskType { get => this._replicaDiskType; set => this._replicaDiskType = value; }

        /// <summary>Backing field for <see cref="SeedManagedDiskId" /> property.</summary>
        private string _seedManagedDiskId;

        /// <summary>Seed managed disk Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string SeedManagedDiskId { get => this._seedManagedDiskId; set => this._seedManagedDiskId = value; }

        /// <summary>Creates an new <see cref="HyperVReplicaAzureManagedDiskDetails" /> instance.</summary>
        public HyperVReplicaAzureManagedDiskDetails()
        {

        }
    }
    /// Hyper-V Managed disk details.
    public partial interface IHyperVReplicaAzureManagedDiskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The disk encryption set ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The disk encryption set ARM Id.",
        SerializedName = @"diskEncryptionSetId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskEncryptionSetId { get; set; }
        /// <summary>The disk Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The disk Id.",
        SerializedName = @"diskId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskId { get; set; }
        /// <summary>The replica disk type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The replica disk type.",
        SerializedName = @"replicaDiskType",
        PossibleTypes = new [] { typeof(string) })]
        string ReplicaDiskType { get; set; }
        /// <summary>Seed managed disk Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Seed managed disk Id.",
        SerializedName = @"seedManagedDiskId",
        PossibleTypes = new [] { typeof(string) })]
        string SeedManagedDiskId { get; set; }

    }
    /// Hyper-V Managed disk details.
    internal partial interface IHyperVReplicaAzureManagedDiskDetailsInternal

    {
        /// <summary>The disk encryption set ARM Id.</summary>
        string DiskEncryptionSetId { get; set; }
        /// <summary>The disk Id.</summary>
        string DiskId { get; set; }
        /// <summary>The replica disk type.</summary>
        string ReplicaDiskType { get; set; }
        /// <summary>Seed managed disk Id.</summary>
        string SeedManagedDiskId { get; set; }

    }
}