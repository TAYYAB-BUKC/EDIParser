using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
				results.Add(ParseLine(line, mappings));
			}

			return results;
		}

		private static Dictionary<string, string> ParseLine(string line, List<EdiMapping> mappings)
		{
			var result = new Dictionary<string, string>();
			var matchedMapping = mappings.FirstOrDefault(m => line.StartsWith(m.Prefix));

			if (matchedMapping == null || !matchedMapping.IsRequired)
				return result;

			var matchedMappings = mappings.Where(m => m.Prefix == matchedMapping.Prefix && m.IsRequired).ToList();
			var elements = line.Split(new[] { matchedMapping.ElementSeparator }, StringSplitOptions.None);

			foreach (var map in matchedMappings)
			{
				if (map.PositionIndex >= elements.Length)
				{
					result[map.ColumnName] = "IndexOutOfRange";
				}
				else
				{
					var rawValue = elements[map.PositionIndex];

					if (!string.IsNullOrWhiteSpace(map.ValidationRegex))
					{
						if (!Regex.IsMatch(rawValue, map.ValidationRegex))
							throw new Exception($"Validation failed for {map.ColumnName} with value: {rawValue}");
					}

					if (map.IsNested && !string.IsNullOrEmpty(Convert.ToString(map.NestedSeparator)))
					{
						var nestedParts = rawValue.Split(new[] { map.NestedSeparator }, StringSplitOptions.None);
						for (int i = 0; i < nestedParts.Length; i++)
						{
							result[$"{map.ColumnName}_{i + 1}"] = nestedParts[i];
						}
					}
					else
					{
						result[map.ColumnName] = rawValue;
					}
				}
			}

			return result;
		}
	}
}