namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMageRcmFailback provider specific details.</summary>
    public partial class InMageRcmFailbackReplicationDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettings"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettings __replicationProviderSpecificSettings = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ReplicationProviderSpecificSettings();

        /// <summary>Backing field for <see cref="AzureVirtualMachineId" /> property.</summary>
        private string _azureVirtualMachineId;

        /// <summary>The ARM Id of the azure VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string AzureVirtualMachineId { get => this._azureVirtualMachineId; }

        /// <summary>Backing field for <see cref="InitialReplicationProcessedByte" /> property.</summary>
        private long? _initialReplicationProcessedByte;

        /// <summary>
        /// The initial replication processed bytes. This includes sum of total bytes transferred and matched bytes on all selected
        /// disks in source VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? InitialReplicationProcessedByte { get => this._initialReplicationProcessedByte; }

        /// <summary>Backing field for <see cref="InitialReplicationProgressHealth" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth? _initialReplicationProgressHealth;

        /// <summary>The initial replication progress health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth? InitialReplicationProgressHealth { get => this._initialReplicationProgressHealth; }

        /// <summary>Backing field for <see cref="InitialReplicationProgressPercentage" /> property.</summary>
        private int? _initialReplicationProgressPercentage;

        /// <summary>The initial replication progress percentage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? InitialReplicationProgressPercentage { get => this._initialReplicationProgressPercentage; }

        /// <summary>Backing field for <see cref="InitialReplicationTransferredByte" /> property.</summary>
        private long? _initialReplicationTransferredByte;

        /// <summary>
        /// The initial replication transferred bytes from source VM to target for all selected disks on source VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? InitialReplicationTransferredByte { get => this._initialReplicationTransferredByte; }

        /// <summary>Gets the Instance type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettingsInternal)__replicationProviderSpecificSettings).InstanceType; }

        /// <summary>Backing field for <see cref="InternalIdentifier" /> property.</summary>
        private string _internalIdentifier;

        /// <summary>The virtual machine internal identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string InternalIdentifier { get => this._internalIdentifier; }

        /// <summary>Backing field for <see cref="LogStorageAccountId" /> property.</summary>
        private string _logStorageAccountId;

        /// <summary>The log storage account ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string LogStorageAccountId { get => this._logStorageAccountId; }

        /// <summary>Internal Acessors for AzureVirtualMachineId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.AzureVirtualMachineId { get => this._azureVirtualMachineId; set { {_azureVirtualMachineId = value;} } }

        /// <summary>Internal Acessors for InitialReplicationProcessedByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.InitialReplicationProcessedByte { get => this._initialReplicationProcessedByte; set { {_initialReplicationProcessedByte = value;} } }

        /// <summary>Internal Acessors for InitialReplicationProgressHealth</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.InitialReplicationProgressHealth { get => this._initialReplicationProgressHealth; set { {_initialReplicationProgressHealth = value;} } }

        /// <summary>Internal Acessors for InitialReplicationProgressPercentage</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.InitialReplicationProgressPercentage { get => this._initialReplicationProgressPercentage; set { {_initialReplicationProgressPercentage = value;} } }

        /// <summary>Internal Acessors for InitialReplicationTransferredByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.InitialReplicationTransferredByte { get => this._initialReplicationTransferredByte; set { {_initialReplicationTransferredByte = value;} } }

        /// <summary>Internal Acessors for InternalIdentifier</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.InternalIdentifier { get => this._internalIdentifier; set { {_internalIdentifier = value;} } }

        /// <summary>Internal Acessors for LogStorageAccountId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.LogStorageAccountId { get => this._logStorageAccountId; set { {_logStorageAccountId = value;} } }

        /// <summary>Internal Acessors for MobilityAgentDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.MobilityAgentDetail { get => (this._mobilityAgentDetail = this._mobilityAgentDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackMobilityAgentDetails()); set { {_mobilityAgentDetail = value;} } }

        /// <summary>Internal Acessors for MobilityAgentDetailAgentVersionExpiryDate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.MobilityAgentDetailAgentVersionExpiryDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).AgentVersionExpiryDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).AgentVersionExpiryDate = value; }

        /// <summary>Internal Acessors for MobilityAgentDetailDriverVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.MobilityAgentDetailDriverVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).DriverVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).DriverVersion = value; }

        /// <summary>Internal Acessors for MobilityAgentDetailDriverVersionExpiryDate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.MobilityAgentDetailDriverVersionExpiryDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).DriverVersionExpiryDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).DriverVersionExpiryDate = value; }

        /// <summary>Internal Acessors for MobilityAgentDetailIsUpgradeable</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.MobilityAgentDetailIsUpgradeable { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).IsUpgradeable; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).IsUpgradeable = value; }

        /// <summary>Internal Acessors for MobilityAgentDetailLastHeartbeatUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.MobilityAgentDetailLastHeartbeatUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).LastHeartbeatUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).LastHeartbeatUtc = value; }

        /// <summary>Internal Acessors for MobilityAgentDetailLatestUpgradableVersionWithoutReboot</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.MobilityAgentDetailLatestUpgradableVersionWithoutReboot { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).LatestUpgradableVersionWithoutReboot; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).LatestUpgradableVersionWithoutReboot = value; }

        /// <summary>Internal Acessors for MobilityAgentDetailLatestVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.MobilityAgentDetailLatestVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).LatestVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).LatestVersion = value; }

        /// <summary>Internal Acessors for MobilityAgentDetailReasonsBlockingUpgrade</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentUpgradeBlockedReason[] Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.MobilityAgentDetailReasonsBlockingUpgrade { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).ReasonsBlockingUpgrade; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).ReasonsBlockingUpgrade = value; }

        /// <summary>Internal Acessors for MobilityAgentDetailVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.MobilityAgentDetailVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).Version = value; }

        /// <summary>Internal Acessors for MultiVMGroupName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.MultiVMGroupName { get => this._multiVMGroupName; set { {_multiVMGroupName = value;} } }

        /// <summary>Internal Acessors for OSType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.OSType { get => this._oSType; set { {_oSType = value;} } }

        /// <summary>Internal Acessors for ReprotectAgentId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.ReprotectAgentId { get => this._reprotectAgentId; set { {_reprotectAgentId = value;} } }

        /// <summary>Internal Acessors for ReprotectAgentName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.ReprotectAgentName { get => this._reprotectAgentName; set { {_reprotectAgentName = value;} } }

        /// <summary>Internal Acessors for ResyncProcessedByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.ResyncProcessedByte { get => this._resyncProcessedByte; set { {_resyncProcessedByte = value;} } }

        /// <summary>Internal Acessors for ResyncProgressHealth</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.ResyncProgressHealth { get => this._resyncProgressHealth; set { {_resyncProgressHealth = value;} } }

        /// <summary>Internal Acessors for ResyncProgressPercentage</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.ResyncProgressPercentage { get => this._resyncProgressPercentage; set { {_resyncProgressPercentage = value;} } }

        /// <summary>Internal Acessors for ResyncRequired</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.ResyncRequired { get => this._resyncRequired; set { {_resyncRequired = value;} } }

        /// <summary>Internal Acessors for ResyncState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ResyncState? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.ResyncState { get => this._resyncState; set { {_resyncState = value;} } }

        /// <summary>Internal Acessors for ResyncTransferredByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.ResyncTransferredByte { get => this._resyncTransferredByte; set { {_resyncTransferredByte = value;} } }

        /// <summary>Internal Acessors for TargetDataStoreName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.TargetDataStoreName { get => this._targetDataStoreName; set { {_targetDataStoreName = value;} } }

        /// <summary>Internal Acessors for TargetVMName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.TargetVMName { get => this._targetVMName; set { {_targetVMName = value;} } }

        /// <summary>Internal Acessors for TargetvCenterId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackReplicationDetailsInternal.TargetvCenterId { get => this._targetvCenterId; set { {_targetvCenterId = value;} } }

        /// <summary>Internal Acessors for InstanceType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettingsInternal.InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettingsInternal)__replicationProviderSpecificSettings).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettingsInternal)__replicationProviderSpecificSettings).InstanceType = value; }

        /// <summary>Backing field for <see cref="MobilityAgentDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetails _mobilityAgentDetail;

        /// <summary>The mobility agent information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetails MobilityAgentDetail { get => (this._mobilityAgentDetail = this._mobilityAgentDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackMobilityAgentDetails()); set => this._mobilityAgentDetail = value; }

        /// <summary>The agent version expiry date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public global::System.DateTime? MobilityAgentDetailAgentVersionExpiryDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).AgentVersionExpiryDate; }

        /// <summary>The driver version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string MobilityAgentDetailDriverVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).DriverVersion; }

        /// <summary>The driver version expiry date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public global::System.DateTime? MobilityAgentDetailDriverVersionExpiryDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).DriverVersionExpiryDate; }

        /// <summary>A value indicating whether agent is upgradeable or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string MobilityAgentDetailIsUpgradeable { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).IsUpgradeable; }

        /// <summary>The time of the last heartbeat received from the agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public global::System.DateTime? MobilityAgentDetailLastHeartbeatUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).LastHeartbeatUtc; }

        /// <summary>The latest upgradeable version available without reboot.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string MobilityAgentDetailLatestUpgradableVersionWithoutReboot { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).LatestUpgradableVersionWithoutReboot; }

        /// <summary>The latest agent version available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string MobilityAgentDetailLatestVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).LatestVersion; }

        /// <summary>The whether update is possible or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentUpgradeBlockedReason[] MobilityAgentDetailReasonsBlockingUpgrade { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).ReasonsBlockingUpgrade; }

        /// <summary>The agent version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string MobilityAgentDetailVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetailsInternal)MobilityAgentDetail).Version; }

        /// <summary>Backing field for <see cref="MultiVMGroupName" /> property.</summary>
        private string _multiVMGroupName;

        /// <summary>The multi VM group name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string MultiVMGroupName { get => this._multiVMGroupName; }

        /// <summary>Backing field for <see cref="OSType" /> property.</summary>
        private string _oSType;

        /// <summary>The type of the OS on the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string OSType { get => this._oSType; }

        /// <summary>Backing field for <see cref="ProtectedDisk" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetails[] _protectedDisk;

        /// <summary>The list of protected disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetails[] ProtectedDisk { get => this._protectedDisk; set => this._protectedDisk = value; }

        /// <summary>Backing field for <see cref="ReprotectAgentId" /> property.</summary>
        private string _reprotectAgentId;

        /// <summary>The reprotect agent Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ReprotectAgentId { get => this._reprotectAgentId; }

        /// <summary>Backing field for <see cref="ReprotectAgentName" /> property.</summary>
        private string _reprotectAgentName;

        /// <summary>The reprotect agent name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ReprotectAgentName { get => this._reprotectAgentName; }

        /// <summary>Backing field for <see cref="ResyncProcessedByte" /> property.</summary>
        private long? _resyncProcessedByte;

        /// <summary>
        /// The resync processed bytes. This includes sum of total bytes transferred and matched bytes on all selected disks in source
        /// VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? ResyncProcessedByte { get => this._resyncProcessedByte; }

        /// <summary>Backing field for <see cref="ResyncProgressHealth" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth? _resyncProgressHealth;

        /// <summary>The resync progress health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth? ResyncProgressHealth { get => this._resyncProgressHealth; }

        /// <summary>Backing field for <see cref="ResyncProgressPercentage" /> property.</summary>
        private int? _resyncProgressPercentage;

        /// <summary>The resync progress percentage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? ResyncProgressPercentage { get => this._resyncProgressPercentage; }

        /// <summary>Backing field for <see cref="ResyncRequired" /> property.</summary>
        private string _resyncRequired;

        /// <summary>A value indicating whether resync is required.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ResyncRequired { get => this._resyncRequired; }

        /// <summary>Backing field for <see cref="ResyncState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ResyncState? _resyncState;

        /// <summary>The resync state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ResyncState? ResyncState { get => this._resyncState; }

        /// <summary>Backing field for <see cref="ResyncTransferredByte" /> property.</summary>
        private long? _resyncTransferredByte;

        /// <summary>
        /// The resync transferred bytes from source VM to target for all selected disks on source VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? ResyncTransferredByte { get => this._resyncTransferredByte; }

        /// <summary>Backing field for <see cref="TargetDataStoreName" /> property.</summary>
        private string _targetDataStoreName;

        /// <summary>The target datastore name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetDataStoreName { get => this._targetDataStoreName; }

        /// <summary>Backing field for <see cref="TargetVMName" /> property.</summary>
        private string _targetVMName;

        /// <summary>The target VM name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetVMName { get => this._targetVMName; }

        /// <summary>Backing field for <see cref="TargetvCenterId" /> property.</summary>
        private string _targetvCenterId;

        /// <summary>The target vCenter Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetvCenterId { get => this._targetvCenterId; }

        /// <summary>Backing field for <see cref="VMNic" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackNicDetails[] _vMNic;

        /// <summary>The network details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackNicDetails[] VMNic { get => this._vMNic; set => this._vMNic = value; }

        /// <summary>Creates an new <see cref="InMageRcmFailbackReplicationDetails" /> instance.</summary>
        public InMageRcmFailbackReplicationDetails()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__replicationProviderSpecificSettings), __replicationProviderSpecificSettings);
            await eventListener.AssertObjectIsValid(nameof(__replicationProviderSpecificSettings), __replicationProviderSpecificSettings);
        }
    }
    /// InMageRcmFailback provider specific details.
    public partial interface IInMageRcmFailbackReplicationDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettings
    {
        /// <summary>The ARM Id of the azure VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The ARM Id of the azure VM.",
        SerializedName = @"azureVirtualMachineId",
        PossibleTypes = new [] { typeof(string) })]
        string AzureVirtualMachineId { get;  }
        /// <summary>
        /// The initial replication processed bytes. This includes sum of total bytes transferred and matched bytes on all selected
        /// disks in source VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The initial replication processed bytes. This includes sum of total bytes transferred and matched bytes on all selected disks in source VM.",
        SerializedName = @"initialReplicationProcessedBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? InitialReplicationProcessedByte { get;  }
        /// <summary>The initial replication progress health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The initial replication progress health.",
        SerializedName = @"initialReplicationProgressHealth",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth? InitialReplicationProgressHealth { get;  }
        /// <summary>The initial replication progress percentage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The initial replication progress percentage.",
        SerializedName = @"initialReplicationProgressPercentage",
        PossibleTypes = new [] { typeof(int) })]
        int? InitialReplicationProgressPercentage { get;  }
        /// <summary>
        /// The initial replication transferred bytes from source VM to target for all selected disks on source VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The initial replication transferred bytes from source VM to target for all selected disks on source VM.",
        SerializedName = @"initialReplicationTransferredBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? InitialReplicationTransferredByte { get;  }
        /// <summary>The virtual machine internal identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The virtual machine internal identifier.",
        SerializedName = @"internalIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string InternalIdentifier { get;  }
        /// <summary>The log storage account ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The log storage account ARM Id.",
        SerializedName = @"logStorageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string LogStorageAccountId { get;  }
        /// <summary>The agent version expiry date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The agent version expiry date.",
        SerializedName = @"agentVersionExpiryDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? MobilityAgentDetailAgentVersionExpiryDate { get;  }
        /// <summary>The driver version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The driver version.",
        SerializedName = @"driverVersion",
        PossibleTypes = new [] { typeof(string) })]
        string MobilityAgentDetailDriverVersion { get;  }
        /// <summary>The driver version expiry date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The driver version expiry date.",
        SerializedName = @"driverVersionExpiryDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? MobilityAgentDetailDriverVersionExpiryDate { get;  }
        /// <summary>A value indicating whether agent is upgradeable or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating whether agent is upgradeable or not.",
        SerializedName = @"isUpgradeable",
        PossibleTypes = new [] { typeof(string) })]
        string MobilityAgentDetailIsUpgradeable { get;  }
        /// <summary>The time of the last heartbeat received from the agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The time of the last heartbeat received from the agent.",
        SerializedName = @"lastHeartbeatUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? MobilityAgentDetailLastHeartbeatUtc { get;  }
        /// <summary>The latest upgradeable version available without reboot.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The latest upgradeable version available without reboot.",
        SerializedName = @"latestUpgradableVersionWithoutReboot",
        PossibleTypes = new [] { typeof(string) })]
        string MobilityAgentDetailLatestUpgradableVersionWithoutReboot { get;  }
        /// <summary>The latest agent version available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The latest agent version available.",
        SerializedName = @"latestVersion",
        PossibleTypes = new [] { typeof(string) })]
        string MobilityAgentDetailLatestVersion { get;  }
        /// <summary>The whether update is possible or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The whether update is possible or not.",
        SerializedName = @"reasonsBlockingUpgrade",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentUpgradeBlockedReason) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentUpgradeBlockedReason[] MobilityAgentDetailReasonsBlockingUpgrade { get;  }
        /// <summary>The agent version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The agent version.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string MobilityAgentDetailVersion { get;  }
        /// <summary>The multi VM group name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The multi VM group name.",
        SerializedName = @"multiVmGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string MultiVMGroupName { get;  }
        /// <summary>The type of the OS on the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of the OS on the VM.",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        string OSType { get;  }
        /// <summary>The list of protected disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of protected disks.",
        SerializedName = @"protectedDisks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetails[] ProtectedDisk { get; set; }
        /// <summary>The reprotect agent Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The reprotect agent Id.",
        SerializedName = @"reprotectAgentId",
        PossibleTypes = new [] { typeof(string) })]
        string ReprotectAgentId { get;  }
        /// <summary>The reprotect agent name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The reprotect agent name.",
        SerializedName = @"reprotectAgentName",
        PossibleTypes = new [] { typeof(string) })]
        string ReprotectAgentName { get;  }
        /// <summary>
        /// The resync processed bytes. This includes sum of total bytes transferred and matched bytes on all selected disks in source
        /// VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resync processed bytes. This includes sum of total bytes transferred and matched bytes on all selected disks in source VM.",
        SerializedName = @"resyncProcessedBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? ResyncProcessedByte { get;  }
        /// <summary>The resync progress health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resync progress health.",
        SerializedName = @"resyncProgressHealth",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth? ResyncProgressHealth { get;  }
        /// <summary>The resync progress percentage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resync progress percentage.",
        SerializedName = @"resyncProgressPercentage",
        PossibleTypes = new [] { typeof(int) })]
        int? ResyncProgressPercentage { get;  }
        /// <summary>A value indicating whether resync is required.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating whether resync is required.",
        SerializedName = @"resyncRequired",
        PossibleTypes = new [] { typeof(string) })]
        string ResyncRequired { get;  }
        /// <summary>The resync state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resync state.",
        SerializedName = @"resyncState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ResyncState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ResyncState? ResyncState { get;  }
        /// <summary>
        /// The resync transferred bytes from source VM to target for all selected disks on source VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resync transferred bytes from source VM to target for all selected disks on source VM.",
        SerializedName = @"resyncTransferredBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? ResyncTransferredByte { get;  }
        /// <summary>The target datastore name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The target datastore name.",
        SerializedName = @"targetDataStoreName",
        PossibleTypes = new [] { typeof(string) })]
        string TargetDataStoreName { get;  }
        /// <summary>The target VM name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The target VM name.",
        SerializedName = @"targetVmName",
        PossibleTypes = new [] { typeof(string) })]
        string TargetVMName { get;  }
        /// <summary>The target vCenter Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The target vCenter Id.",
        SerializedName = @"targetvCenterId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetvCenterId { get;  }
        /// <summary>The network details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The network details.",
        SerializedName = @"vmNics",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackNicDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackNicDetails[] VMNic { get; set; }

    }
    /// InMageRcmFailback provider specific details.
    internal partial interface IInMageRcmFailbackReplicationDetailsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettingsInternal
    {
        /// <summary>The ARM Id of the azure VM.</summary>
        string AzureVirtualMachineId { get; set; }
        /// <summary>
        /// The initial replication processed bytes. This includes sum of total bytes transferred and matched bytes on all selected
        /// disks in source VM.
        /// </summary>
        long? InitialReplicationProcessedByte { get; set; }
        /// <summary>The initial replication progress health.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth? InitialReplicationProgressHealth { get; set; }
        /// <summary>The initial replication progress percentage.</summary>
        int? InitialReplicationProgressPercentage { get; set; }
        /// <summary>
        /// The initial replication transferred bytes from source VM to target for all selected disks on source VM.
        /// </summary>
        long? InitialReplicationTransferredByte { get; set; }
        /// <summary>The virtual machine internal identifier.</summary>
        string InternalIdentifier { get; set; }
        /// <summary>The log storage account ARM Id.</summary>
        string LogStorageAccountId { get; set; }
        /// <summary>The mobility agent information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackMobilityAgentDetails MobilityAgentDetail { get; set; }
        /// <summary>The agent version expiry date.</summary>
        global::System.DateTime? MobilityAgentDetailAgentVersionExpiryDate { get; set; }
        /// <summary>The driver version.</summary>
        string MobilityAgentDetailDriverVersion { get; set; }
        /// <summary>The driver version expiry date.</summary>
        global::System.DateTime? MobilityAgentDetailDriverVersionExpiryDate { get; set; }
        /// <summary>A value indicating whether agent is upgradeable or not.</summary>
        string MobilityAgentDetailIsUpgradeable { get; set; }
        /// <summary>The time of the last heartbeat received from the agent.</summary>
        global::System.DateTime? MobilityAgentDetailLastHeartbeatUtc { get; set; }
        /// <summary>The latest upgradeable version available without reboot.</summary>
        string MobilityAgentDetailLatestUpgradableVersionWithoutReboot { get; set; }
        /// <summary>The latest agent version available.</summary>
        string MobilityAgentDetailLatestVersion { get; set; }
        /// <summary>The whether update is possible or not.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AgentUpgradeBlockedReason[] MobilityAgentDetailReasonsBlockingUpgrade { get; set; }
        /// <summary>The agent version.</summary>
        string MobilityAgentDetailVersion { get; set; }
        /// <summary>The multi VM group name.</summary>
        string MultiVMGroupName { get; set; }
        /// <summary>The type of the OS on the VM.</summary>
        string OSType { get; set; }
        /// <summary>The list of protected disks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetails[] ProtectedDisk { get; set; }
        /// <summary>The reprotect agent Id.</summary>
        string ReprotectAgentId { get; set; }
        /// <summary>The reprotect agent name.</summary>
        string ReprotectAgentName { get; set; }
        /// <summary>
        /// The resync processed bytes. This includes sum of total bytes transferred and matched bytes on all selected disks in source
        /// VM.
        /// </summary>
        long? ResyncProcessedByte { get; set; }
        /// <summary>The resync progress health.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.VMReplicationProgressHealth? ResyncProgressHealth { get; set; }
        /// <summary>The resync progress percentage.</summary>
        int? ResyncProgressPercentage { get; set; }
        /// <summary>A value indicating whether resync is required.</summary>
        string ResyncRequired { get; set; }
        /// <summary>The resync state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ResyncState? ResyncState { get; set; }
        /// <summary>
        /// The resync transferred bytes from source VM to target for all selected disks on source VM.
        /// </summary>
        long? ResyncTransferredByte { get; set; }
        /// <summary>The target datastore name.</summary>
        string TargetDataStoreName { get; set; }
        /// <summary>The target VM name.</summary>
        string TargetVMName { get; set; }
        /// <summary>The target vCenter Id.</summary>
        string TargetvCenterId { get; set; }
        /// <summary>The network details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackNicDetails[] VMNic { get; set; }

    }
}