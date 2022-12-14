using BL;
using BL.Enums;
using ShellTestApp;
using System;
using System.Diagnostics;

namespace Commander
{
	public partial class Main : Form
	{
		private const int COLUMN_FULL_NAME = 0;
		private const int COLUMN_TYPE_OBJECT = 1;
		private const int COLUMN_NAME = 2;
		private Split CurrentSplit;
		private string CurrentDirLeft = "";
		private string CurrentDirRight = "";
		private bool ShowHideObject = false;
		
		private List<DriveInfo> DeviceList => DriveInfo.GetDrives().ToList();

		public Main()
		{
			InitializeComponent();
		}

		#region ????????? ? ??????? ?????????????

		private void InitialComboboxDevices()
		{
			var i = 1;

			foreach (var drive in DeviceList)
			{
				try
				{
					comboBoxDevicesLeft.Items.Add($"{drive.Name.Substring(0, 1)} [{drive.VolumeLabel}]");
					comboBoxDevicesRight.Items.Add($"{drive.Name.Substring(0, 1)} [{drive.VolumeLabel}]");
					toolStripDiskLeft.Items.Add(new ToolStripButton()
					{
						Name = $"toolStripLeftButton_{i}",
						Text = $"{drive.Name.Substring(0, 1)}",
						ToolTipText = $"{drive.Name.Substring(0, 1)} [{drive.VolumeLabel}]",
						DisplayStyle = ToolStripItemDisplayStyle.Text,
						Width = Height
					});
					toolStripDiskRight.Items.Add(new ToolStripButton()
					{
						Name = $"toolStripRightButton_{i}",
						Text = $"{drive.Name.Substring(0, 1)}",
						ToolTipText = $"{drive.Name.Substring(0, 1)} [{drive.VolumeLabel}]",
						DisplayStyle = ToolStripItemDisplayStyle.Text,
						Width = Height
					});

				}
				catch { }

				i++;
			}

			ChangeDefaultDrive();
		}

		#endregion

		#region ????????? ????????? ? ?????

		private void OpenObject(DataGridViewRow row)
		{
			if (string.Equals(row.Cells[COLUMN_TYPE_OBJECT].Value, TypeObject.Directory))
			{
				var path = row.Cells[COLUMN_FULL_NAME].Value.ToString();
				var name = row.Cells[COLUMN_NAME].Value.ToString();

				if (string.IsNullOrWhiteSpace(path))
				{
					throw new ArgumentNullException("???? ?? ????? ???? ?????? ??? ?????? Null", nameof(path));
				}

				if (string.IsNullOrWhiteSpace(name))
				{
					throw new ArgumentNullException("??? ????? ?? ????? ???? ?????? ??? ?????? Null", nameof(name));
				}

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

#pragma warning disable CS8600 // ?????????????? ????????, ???????????? ???????? NULL ??? ?????????? ???????? NULL ? ???, ?? ??????????? ???????? NULL.
			DataGridViewRow row = gridView.Rows.Cast<DataGridViewRow>()
				.FirstOrDefault(r => r.Cells[COLUMN_FULL_NAME].Value.ToString().Equals(searchName));
#pragma warning restore CS8600 // ?????????????? ????????, ???????????? ???????? NULL ??? ?????????? ???????? NULL ? ???, ?? ??????????? ???????? NULL.

			if (row != null)
			{
				rowIndex = row.Index;
				gridView.ClearSelection();
				gridView.Rows[rowIndex].Selected = true;
			}
		}

		private string GetDriveInfo(string device)
		{
			string devInfo = "";
			var result = DriveInfo.GetDrives().FirstOrDefault(x => x.Name.StartsWith(device));

			if (result != null)
			{
				devInfo = $"[{result.VolumeLabel}] {Dir.GetSizeSuffix(result.TotalFreeSpace)} ?? {Dir.GetSizeSuffix(result.TotalSize)} ????????";
			}
			
			return devInfo;
		}
		
		private void ChangeDefaultDrive()
		{
			if (DeviceList.Count > 0)
			{
				comboBoxDevicesLeft.SelectedIndex = 0;
				comboBoxDevicesRight.SelectedIndex = 1;
#pragma warning disable CS8602 // ????????????? ????????? ?????? ??????.
				(toolStripDiskLeft.Items[0] as ToolStripButton).Checked = true;
#pragma warning restore CS8602 // ????????????? ????????? ?????? ??????.
#pragma warning disable CS8602 // ????????????? ????????? ?????? ??????.
				(toolStripDiskRight.Items[1] as ToolStripButton).Checked = true;
#pragma warning restore CS8602 // ????????????? ????????? ?????? ??????.
			}
		}

		private void LoadDataGridView(DataGridView gridView, string path)
		{
			List<DirStructure> dirList = Dir.GetDirectoriesInfo(path);
			gridView.DataSource = !ShowHideObject 
				? dirList 
				: dirList.Where(x => x.Attribute.IndexOf("h") == -1 && x.Attribute.IndexOf("s") == -1).ToList();

			if (gridView.Name.IndexOf("Left") != -1)
			{
				if (!CurrentDirLeft.Equals(path))
				{
					CurrentDirLeft = path;
				}
				
			}
			else 
			{
				if (!CurrentDirRight.Equals(path))
				{
					CurrentDirRight = path;
				}
			}
		}

		private void ReloadDataGridView(DataGridView gridView, string fullPath)
		{
			if (!Directory.Exists(fullPath))
			{
				throw new ArgumentNullException("???? ? ???????? ?? ??????", nameof(fullPath));
			}

			if (gridView == null)
			{
				throw new ArgumentNullException("?????? DataGridView ?? ????? ???? Null", nameof(gridView));
			}

			var selectedRows = gridView.SelectedRows;
			var listIndexes = new List<int>();

			foreach (DataGridViewRow item in selectedRows)
			{
				listIndexes.Add(item.Index);
			}

			LoadDataGridView(gridView, fullPath);
			listIndexes.Sort();

			for (int i = 0; i < listIndexes.Count; i++)
			{
				DataGridViewRow? row = gridView.Rows.OfType<DataGridViewRow>().Where(x => x.Index == listIndexes[i]).SingleOrDefault();

				if (row != null)
				{
					if (i == 0)
					{
						gridView.ClearSelection();
						gridView.CurrentCell = gridView[COLUMN_NAME, listIndexes[i]];
					}

					row.Selected = true;
				}
			}
		}

		private void OnCheckedToolStripButtonDisk(ToolStrip toolStrip, string nameItem)
		{
			for (int i = 0; i < toolStrip.Items.Count; i++)
			{
				ToolStripButton? item = toolStrip.Items[i] as ToolStripButton;

				if (item != null)
				{
					item.Checked = item.Name.Equals(nameItem);
				}
			}
		}

		private void GetCurrentSplit(string name)
		{
			switch (name)
			{
				case "dataGridViewLeft":
					CurrentSplit = Split.Left;
					break;
				case "dataGridViewRight":
					CurrentSplit = Split.Right;
					break;
			}
		}
		
		#endregion

		#region ??????? ?????

		private void Main_Load(object sender, EventArgs e)
		{
			InitialComboboxDevices();
		}

		private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (sender is DataGridView dataGrid)
			{
				GetCurrentSplit(dataGrid.Name);

				if (e.Button == MouseButtons.Left && e.RowIndex >= 0)
				{
					OpenObject(dataGrid.Rows[e.RowIndex]);
				}
			}
		}

		private void dataGridView_MouseUp(object sender, MouseEventArgs e)
		{
			// @TODO ???????? ??? ??????????? ??????????? ????, ? ?????? ?????? ?? ???? ??????????? ???????? ????
			//if (e.Button == MouseButtons.Right)
			//{
			//	if (sender is DataGridView dataGrid)
			//	{
			//		var rows = dataGrid.SelectedRows;
			//		FileInfo[] arrFI = new FileInfo[rows.Count];

			//		for (var i = 0; i < rows.Count; i++)
			//		{
			//			var fullName = rows[i].Cells[COLUMN_FULL_NAME].Value.ToString() ?? "";

			//			if (!string.IsNullOrWhiteSpace(fullName))
			//			{
			//				arrFI[i] = new FileInfo(fullName);
			//			}
			//		}

			//		if (arrFI.Length > 0)
			//		{
			//			var X = e.X;
			//			var Y = e.Y;

			//			if (CurrentSplit == Split.Right)
			//			{
			//				X = X + dataGrid.Location.X;
			//			}

			//			new ShellContextMenu().ShowContextMenu(arrFI, this.PointToScreen(new Point(X, Y)));
			//		}
			//	}
			//}
		}

		private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (sender is DataGridView gridView)
			{
				GetCurrentSplit(gridView.Name);

				if (e.Button == MouseButtons.Right)
				{
					var result = gridView.Rows.Cast<DataGridViewRow>().SingleOrDefault(x => x.Index == e.RowIndex && x.Selected);

					if (result == null)
					{
						gridView.ClearSelection();
						gridView.Rows[e.RowIndex].Selected = true;
					}
				}
			}
		}

		private void comboBoxDevicesLeft_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (sender is ComboBox comboBox)
			{
				var deviceName = comboBox.SelectedItem.ToString()?.Substring(0, 1);

				if (!string.IsNullOrWhiteSpace(deviceName))
				{
					var fullName = $"{deviceName}:\\";
					labelDeviceInfoLeft.Text = GetDriveInfo(deviceName);
					LoadDataGridView(dataGridViewLeft, fullName);
					CurrentDirLeft = fullName;
				}
			}

		}

		private void comboBoxDevicesRight_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (sender is ComboBox comboBox)
			{
				var deviceName = comboBox.SelectedItem.ToString()?.Substring(0, 1);

				if (!string.IsNullOrWhiteSpace(deviceName))
				{
					var fullName = $"{deviceName}:\\";
					labelDeviceInfoRight.Text = GetDriveInfo(deviceName);
					LoadDataGridView(dataGridViewRight, fullName);
					CurrentDirRight = fullName;
				}
			}
		}

		private void toolStripDiskLeft_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			if (e.ClickedItem is ToolStripButton button)
			{
				var text = button.ToolTipText;

				if (!string.IsNullOrWhiteSpace(text))
				{
					var index = comboBoxDevicesLeft.FindStringExact(text);
					comboBoxDevicesLeft.SelectedIndex = index != -1 ? index : index++;
					OnCheckedToolStripButtonDisk(toolStripDiskLeft, button.Name);
				}
			}
		}

		private void toolStripDiskRight_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			if (e.ClickedItem is ToolStripButton button)
			{
				var text = button.ToolTipText;

				if (!string.IsNullOrWhiteSpace(text))
				{
					var index = comboBoxDevicesRight.FindStringExact(text);
					comboBoxDevicesRight.SelectedIndex = index != -1 ? index : index++;
					OnCheckedToolStripButtonDisk(toolStripDiskRight, button.Name);
				}
			}
		}

		private void btnEditAttributes_Click(object sender, EventArgs e)
		{
			var gridView = CurrentSplit == Split.Left ? dataGridViewLeft : dataGridViewRight;
			var listPath = new List<string>();

			foreach (DataGridViewRow row in gridView.SelectedRows)
			{
				var fullPath = row.Cells[COLUMN_FULL_NAME].Value.ToString();

				if (!string.IsNullOrWhiteSpace(fullPath))
				{
					listPath.Add(fullPath);
				}
			}

			var form = new Attribute(listPath);
			if (form.ShowDialog() == DialogResult.OK)
			{
				if (CurrentSplit == Split.Left)
				{
					ReloadDataGridView(dataGridViewLeft, CurrentDirLeft);
				}
				else
				{
					ReloadDataGridView(dataGridViewRight, CurrentDirRight);
				}
			}
		}

		private void btnShowHidden_Click(object sender, EventArgs e)
		{
			ShowHideObject = !ShowHideObject;
			ReloadDataGridView(dataGridViewLeft, CurrentDirLeft);
			ReloadDataGridView(dataGridViewRight, CurrentDirRight);
		}

		#endregion
	}
}