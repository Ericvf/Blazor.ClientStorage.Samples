namespace Blazor.ClientStorage.Samples
{
    public class LocationObjectStore : KeyPathObjectStore<Location, string>
    {
        public LocationObjectStore(IBlazorClientStorage blazorClientStorage) 
            : base(blazorClientStorage)
        {
        }

        public override string Name => nameof(Location);

        public override ObjectStoreDescriptor GetObjectStoreDescriptor() =>
            new()
            {
                Name = this.Name,
                Options = new()
                {
                    keyPath = nameof(Person.name)
                }
            };
    }

    public class Location : IObjectStoreModel<string>
    {
        public string key { get; set; }

        public string name { get; set; }
    }
}
