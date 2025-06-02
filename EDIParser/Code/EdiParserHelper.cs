using System.Collections.Generic;

namespace EDIParser.Code
{
	public class EdiParserHelper
    {
        public static List<Dictionary<string, string>> ParseLines(List<string> ediLines, List<EdiMapping> mappings)
        {
            var results = new List<Dictionary<string, string>>();
            foreach (var line in ediLines)
            {
                // Read and Parse each line according to the mapping
            }

            return results;
        }
    }
}