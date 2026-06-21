using System.Collections.Generic;

namespace EntityFrameworkCoreDemo.Relationships
{
    public class Tag
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<string> Employees { get; set; }
    }
}
