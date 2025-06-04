using EDIParser.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			var connection = "Server=DESKTOP-MTIIACB\\SQLEXPRESS;Initial Catalog=Test;Persist Security Info=False;Integrated Security = True; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;";
			var format = 1;
			var mappings = DatabaseHelper.GetMappingsFromDb(connection, format);

			var parsed = EdiParserHelper.ParseLines(content.ToList(), mappings);
			
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
