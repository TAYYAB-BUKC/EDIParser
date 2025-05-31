using System.IO;

namespace EDIParser.Code
{
	public static class FileHelper
    {
        public static string[] ReadFile(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllLines(path);
            }

            return new string[] { };
        }
    }
}