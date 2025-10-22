using System.IO;

public class FileReader
{
    public static FileData ReadTextFileIntoStruct(string filepath)
    {
        FileData data = new FileData();
        data.Content = File.ReadAllText(filepath);
        return data;
    }
}
