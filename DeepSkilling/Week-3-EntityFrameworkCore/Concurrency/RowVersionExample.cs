using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCoreDemo.Concurrency
{
    public class RowVersionExample
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
