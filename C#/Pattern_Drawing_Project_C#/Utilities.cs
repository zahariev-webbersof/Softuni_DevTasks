using System;
using System.IO;

public static class Utilities
{
    public static void SavePatternToFile(string pattern, string fileName)
    {
        File.WriteAllText(fileName, pattern);
    }
}
