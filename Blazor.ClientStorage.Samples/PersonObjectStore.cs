namespace Blazor.ClientStorage.Samples
{
    public class PersonObjectStore : AutoIncrementObjectStore<Person>
    {
        public PersonObjectStore(IBlazorClientStorage blazorClientStorage)
            : base(blazorClientStorage)
        {
        }

        public override string Name => nameof(Person);

        public override ObjectStoreDescriptor GetObjectStoreDescriptor() =>
            new()
            {
                Name = this.Name,
                Options = new()
                {
                    autoIncrement = true
                }
            };
    }

    public class Person : IObjectStoreModel<int>
    {
        public int key { get; set; }

        public string name { get; set; }

        public int age { get; set; }
    }
}
