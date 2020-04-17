namespace Demo.Models
{
    public class Framework
    {
        public Framework()
        {
            
        }
        public Framework(string slug, string version, string name)
        {
            Slug = slug;
            Version = version;
            Name = name;
        }
        public string Slug { get; }
        public string Version { get; }
        public string Name { get; }
    }
}