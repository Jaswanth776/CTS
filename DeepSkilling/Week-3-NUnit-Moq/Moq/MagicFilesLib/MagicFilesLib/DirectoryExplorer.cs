using System.IO;

namespace MagicFilesLib;

public class DirectoryExplorer
{
    private readonly IDirectoryExplorer _directoryExplorer;

    public DirectoryExplorer(IDirectoryExplorer directoryExplorer)
    {
        _directoryExplorer = directoryExplorer;
    }

    public int GetTotalFiles(string path)
    {
        List<string> files = _directoryExplorer.GetFiles(path);
        return files.Count;
    }
}
