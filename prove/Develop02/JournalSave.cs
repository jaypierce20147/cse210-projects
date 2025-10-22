using System.IO;

public class JournalSave
{
    public void EntrySaved(string fileReceived)
    {
        // No lines to add right now, but method is here in case it's expanded later.
        File.AppendAllLines(fileReceived, new string[] { });
    }
}
