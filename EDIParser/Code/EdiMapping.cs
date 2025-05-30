namespace EDIParser.Code
{
	public class EdiMapping
	{
		public int Id { get; set; }
		public string ColumnName { get; set; }
		public string DataType { get; set; }
		public string DefaultValue { get; set; }
		public string Prefix { get; set; }
		public string ElementSeparator { get; set; }
		public int PositionIndex { get; set; }
		public string ValidationRegex { get; set; }
		public string FormatType { get; set; }
		public bool IsRequired { get; set; }
		public bool IsNested { get; set; }
		public string NestedSeparator { get; set; }
	}
}