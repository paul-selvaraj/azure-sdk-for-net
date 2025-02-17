namespace Azure.ResourceManager.FluidRelay
{
    public partial class FluidRelayContainerCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.FluidRelay.FluidRelayContainerResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.FluidRelay.FluidRelayContainerResource>, System.Collections.IEnumerable
    {
        protected FluidRelayContainerCollection() { }
        public virtual Azure.Response<bool> Exists(string fluidRelayContainerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string fluidRelayContainerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.FluidRelay.FluidRelayContainerResource> Get(string fluidRelayContainerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.FluidRelay.FluidRelayContainerResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.FluidRelay.FluidRelayContainerResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.FluidRelay.FluidRelayContainerResource>> GetAsync(string fluidRelayContainerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.FluidRelay.FluidRelayContainerResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.FluidRelay.FluidRelayContainerResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.FluidRelay.FluidRelayContainerResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.FluidRelay.FluidRelayContainerResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class FluidRelayContainerData : Azure.ResourceManager.Models.ResourceData
    {
        public FluidRelayContainerData() { }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public System.Guid? FrsContainerId { get { throw null; } }
        public System.Guid? FrsTenantId { get { throw null; } }
        public System.DateTimeOffset? LastAccessOn { get { throw null; } }
        public Azure.ResourceManager.FluidRelay.Models.ProvisioningState? ProvisioningState { get { throw null; } }
    }
    public partial class FluidRelayContainerResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected FluidRelayContainerResource() { }
        public virtual Azure.ResourceManager.FluidRelay.FluidRelayContainerData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroup, string fluidRelayServerName, string fluidRelayContainerName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.FluidRelay.FluidRelayContainerResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.FluidRelay.FluidRelayContainerResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class FluidRelayExtensions
    {
        public static Azure.ResourceManager.FluidRelay.FluidRelayContainerResource GetFluidRelayContainerResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.FluidRelay.Models.OperationResult> GetFluidRelayOperations(this Azure.ResourceManager.Resources.TenantResource tenantResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.FluidRelay.Models.OperationResult> GetFluidRelayOperationsAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.FluidRelay.FluidRelayServerResource> GetFluidRelayServer(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string fluidRelayServerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.FluidRelay.FluidRelayServerResource>> GetFluidRelayServerAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string fluidRelayServerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.FluidRelay.FluidRelayServerResource GetFluidRelayServerResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.FluidRelay.FluidRelayServerCollection GetFluidRelayServers(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.FluidRelay.FluidRelayServerResource> GetFluidRelayServers(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.FluidRelay.FluidRelayServerResource> GetFluidRelayServersAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class FluidRelayServerCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.FluidRelay.FluidRelayServerResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.FluidRelay.FluidRelayServerResource>, System.Collections.IEnumerable
    {
        protected FluidRelayServerCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.FluidRelay.FluidRelayServerResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string fluidRelayServerName, Azure.ResourceManager.FluidRelay.FluidRelayServerData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.FluidRelay.FluidRelayServerResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string fluidRelayServerName, Azure.ResourceManager.FluidRelay.FluidRelayServerData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string fluidRelayServerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string fluidRelayServerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.FluidRelay.FluidRelayServerResource> Get(string fluidRelayServerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.FluidRelay.FluidRelayServerResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.FluidRelay.FluidRelayServerResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.FluidRelay.FluidRelayServerResource>> GetAsync(string fluidRelayServerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.FluidRelay.FluidRelayServerResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.FluidRelay.FluidRelayServerResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.FluidRelay.FluidRelayServerResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.FluidRelay.FluidRelayServerResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class FluidRelayServerData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public FluidRelayServerData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public Azure.ResourceManager.FluidRelay.Models.CustomerManagedKeyEncryptionProperties CustomerManagedKeyEncryption { get { throw null; } set { } }
        public Azure.ResourceManager.FluidRelay.Models.FluidRelayEndpoints FluidRelayEndpoints { get { throw null; } }
        public System.Guid? FrsTenantId { get { throw null; } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public Azure.ResourceManager.FluidRelay.Models.ProvisioningState? ProvisioningState { get { throw null; } set { } }
        public Azure.ResourceManager.FluidRelay.Models.StorageSku? StorageSku { get { throw null; } set { } }
    }
    public partial class FluidRelayServerResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected FluidRelayServerResource() { }
        public virtual Azure.ResourceManager.FluidRelay.FluidRelayServerData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.FluidRelay.FluidRelayServerResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.FluidRelay.FluidRelayServerResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroup, string fluidRelayServerName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.FluidRelay.FluidRelayServerResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.FluidRelay.FluidRelayServerResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.FluidRelay.FluidRelayContainerResource> GetFluidRelayContainer(string fluidRelayContainerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.FluidRelay.FluidRelayContainerResource>> GetFluidRelayContainerAsync(string fluidRelayContainerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.FluidRelay.FluidRelayContainerCollection GetFluidRelayContainers() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.FluidRelay.Models.FluidRelayServerKeys> GetKeys(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.FluidRelay.Models.FluidRelayServerKeys>> GetKeysAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.FluidRelay.Models.FluidRelayServerKeys> RegenerateKey(Azure.ResourceManager.FluidRelay.Models.RegenerateKeyContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.FluidRelay.Models.FluidRelayServerKeys>> RegenerateKeyAsync(Azure.ResourceManager.FluidRelay.Models.RegenerateKeyContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.FluidRelay.FluidRelayServerResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.FluidRelay.FluidRelayServerResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.FluidRelay.FluidRelayServerResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.FluidRelay.FluidRelayServerResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.FluidRelay.FluidRelayServerResource> Update(Azure.ResourceManager.FluidRelay.Models.FluidRelayServerPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.FluidRelay.FluidRelayServerResource>> UpdateAsync(Azure.ResourceManager.FluidRelay.Models.FluidRelayServerPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.FluidRelay.Models
{
    public enum CmkIdentityType
    {
        SystemAssigned = 0,
        UserAssigned = 1,
    }
    public partial class CustomerManagedKeyEncryptionProperties
    {
        public CustomerManagedKeyEncryptionProperties() { }
        public Azure.ResourceManager.FluidRelay.Models.CustomerManagedKeyEncryptionPropertiesKeyEncryptionKeyIdentity KeyEncryptionKeyIdentity { get { throw null; } set { } }
        public System.Uri KeyEncryptionKeyUri { get { throw null; } set { } }
    }
    public partial class CustomerManagedKeyEncryptionPropertiesKeyEncryptionKeyIdentity
    {
        public CustomerManagedKeyEncryptionPropertiesKeyEncryptionKeyIdentity() { }
        public Azure.ResourceManager.FluidRelay.Models.CmkIdentityType? IdentityType { get { throw null; } set { } }
        public string UserAssignedIdentityResourceId { get { throw null; } set { } }
    }
    public partial class FluidRelayEndpoints
    {
        internal FluidRelayEndpoints() { }
        public System.Collections.Generic.IReadOnlyList<string> OrdererEndpoints { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> ServiceEndpoints { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> StorageEndpoints { get { throw null; } }
    }
    public partial class FluidRelayServerKeys
    {
        internal FluidRelayServerKeys() { }
        public string Key1 { get { throw null; } }
        public string Key2 { get { throw null; } }
    }
    public partial class FluidRelayServerPatch
    {
        public FluidRelayServerPatch() { }
        public Azure.ResourceManager.FluidRelay.Models.CustomerManagedKeyEncryptionProperties CustomerManagedKeyEncryption { get { throw null; } set { } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public Azure.Core.AzureLocation? Location { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
    }
    public enum KeyName
    {
        Key1 = 0,
        Key2 = 1,
    }
    public partial class OperationDisplay
    {
        internal OperationDisplay() { }
        public string Description { get { throw null; } }
        public string Operation { get { throw null; } }
        public string Provider { get { throw null; } }
        public string Resource { get { throw null; } }
    }
    public partial class OperationResult
    {
        internal OperationResult() { }
        public Azure.ResourceManager.FluidRelay.Models.OperationDisplay Display { get { throw null; } }
        public bool? IsDataAction { get { throw null; } }
        public string Name { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.FluidRelay.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.FluidRelay.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.FluidRelay.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.FluidRelay.Models.ProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.FluidRelay.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.FluidRelay.Models.ProvisioningState left, Azure.ResourceManager.FluidRelay.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.FluidRelay.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.FluidRelay.Models.ProvisioningState left, Azure.ResourceManager.FluidRelay.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RegenerateKeyContent
    {
        public RegenerateKeyContent(Azure.ResourceManager.FluidRelay.Models.KeyName keyName) { }
        public Azure.ResourceManager.FluidRelay.Models.KeyName KeyName { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct StorageSku : System.IEquatable<Azure.ResourceManager.FluidRelay.Models.StorageSku>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public StorageSku(string value) { throw null; }
        public static Azure.ResourceManager.FluidRelay.Models.StorageSku Basic { get { throw null; } }
        public static Azure.ResourceManager.FluidRelay.Models.StorageSku Standard { get { throw null; } }
        public bool Equals(Azure.ResourceManager.FluidRelay.Models.StorageSku other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.FluidRelay.Models.StorageSku left, Azure.ResourceManager.FluidRelay.Models.StorageSku right) { throw null; }
        public static implicit operator Azure.ResourceManager.FluidRelay.Models.StorageSku (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.FluidRelay.Models.StorageSku left, Azure.ResourceManager.FluidRelay.Models.StorageSku right) { throw null; }
        public override string ToString() { throw null; }
    }
}
