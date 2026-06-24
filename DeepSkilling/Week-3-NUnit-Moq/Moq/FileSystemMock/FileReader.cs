namespace MoqDemo.FileSystemMock
{
    public class FileReader
    {
        private readonly IFileSystem fileSystem;

        public FileReader(IFileSystem fileSystem)
        {
            this.fileSystem = fileSystem;
        }

        public string GetFileContent(string path)
        {
            return fileSystem.ReadFile(path);
        }
    }
}
