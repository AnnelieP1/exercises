using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Försök_TeaterGruppen.SaveToFileAndReadToFile;

public class FileService
{
    private static readonly string filePath = @"c:\Code\actermembers.json";
    public static void SaveToFile(string filePath, string contentAsJson)
    {
        using var sw = new StreamWriter(filePath);
        sw.Write(contentAsJson);
    }

    public static string ReadFromFile()
    {
        if (File.Exists(filePath))
        {
            using var sr = new StreamReader(filePath);
            return sr.ReadToEnd();
        }
        return null!;

    }
}
