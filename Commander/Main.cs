using BL;
using BL.Enums;
using System.Diagnostics;

namespace Commander
{
	public partial class Main : Form
	{
		private const int COLUMN_NAME = 0;
		private const int COLUMN_FULL_NAME = 1;
		private const int COLUMN_TYPE_OBJECT = 6;
		
		private Split CurrentSplit;
		private string CurrentDirLeft = "";
		private string CurrentDirRight = "";

		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			InitialDataGridView();
			InitialSplitControl();
		}

		private void Main_Resize(object sender, EventArgs e)
		{
			InitialSplitControl();
		}

		private void InitialSplitControl()
		{
			var width = splitContainer.Width - splitContainer.SplitterWidth;
			splitContainer.SplitterDistance = width / 2;
		}

		private void InitialDataGridView()
		{
			var currentPath = @"C:\";
			List<DirStructure> dirListLeft = Dir.GetDirectoriesInfo(currentPath);
			List<DirStructure> dirListRight = Dir.GetDirectoriesInfo(currentPath);
			dataGridViewLeft.DataSource = dirListLeft;
			dataGridViewRight.DataSource = dirListRight;
		}

		private void OpenObject(DataGridViewRow row)
		{
			if (string.Equals(row.Cells[COLUMN_TYPE_OBJECT].Value, TypeObject.Directory))
			{
				var path = row.Cells[COLUMN_FULL_NAME].Value.ToString();
				var name = row.Cells[COLUMN_NAME].Value.ToString();
				List<DirStructure> dirList = Dir.GetDirectoriesInfo(path);

				if (CurrentSplit == Split.Left)
				{
					dataGridViewLeft.DataSource = dirList;

					if (name.Equals(".."))
					{
						SelectCurrentRow(dataGridViewLeft, CurrentDirLeft);
					}

					CurrentDirLeft = path;
				}
				else
				{
					dataGridViewRight.DataSource = dirList;

					if (name.Equals(".."))
					{
						SelectCurrentRow(dataGridViewRight, CurrentDirRight);
					}

					CurrentDirRight = path;
				}
			}
			else if (string.Equals(row.Cells[COLUMN_TYPE_OBJECT].Value, TypeObject.File))
			{
				var fullName = row.Cells[COLUMN_FULL_NAME].Value.ToString();

				if (fullName != null)
				{
					new Process 
					{ 
						StartInfo = new ProcessStartInfo(fullName) 
						{
							UseShellExecute = true 
						} 
					}.Start();
				}
			}
		}

		private void SelectCurrentRow(DataGridView gridView, string searchName)
		{
			int rowIndex = -1;

			DataGridViewRow row = gridView.Rows.Cast<DataGridViewRow>()
				.FirstOrDefault(r => r.Cells[COLUMN_FULL_NAME].Value.ToString().Equals(searchName));

			if (row != null)
			{
				rowIndex = row.Index;
				gridView.ClearSelection();
				gridView.Rows[rowIndex].Selected = true;
			}
		}

		private void dataGridViewLeft_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			CurrentSplit = Split.Left;
			OpenObject(dataGridViewLeft.Rows[e.RowIndex]);
		}

		private void dataGridViewRight_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			CurrentSplit = Split.Right;
			OpenObject(dataGridViewRight.Rows[e.RowIndex]);
		}
	}
}