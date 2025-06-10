using EDIParser.Code;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace EDIParser
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Btn_EDIParser_Click(object sender, EventArgs e)
		{
			var path = Txt_Path.Text;

			if (path is null)
			{
				MessageBox.Show("Path is empty");
			}

			var content = FileHelper.ReadFile(path);
			var connection = Convert.ToString(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
			var format = 1;
			var mappings = DatabaseHelper.GetMappingsFromDb(connection, format);

			var parsed = EdiParserHelper.ParseLines(content.ToList(), mappings);

			listBox1.Items.Clear();

			foreach (var row in parsed)
			{
				foreach (var rowItem in row)
				{
					listBox1.Items.Add($"{rowItem.Key}: {rowItem.Value}");
				}
			}
		}
	}
}
