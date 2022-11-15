using BL;
using BL.Enums;
using ShellTestApp;
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
		private List<DriveInfo> DeviceList;

		public Main()
		{
			InitializeComponent();
		}

		#region ѕроцедуры и функции инициализации

		private void InitialComboboxDevices()
		{
			DeviceList = DriveInfo.GetDrives().ToList();
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

		#region —лужебные процедуры и формы

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

#pragma warning disable CS8600 // ѕреобразование литерала, допускающего значение NULL или возможного значени€ NULL в тип, не допускающий значение NULL.
			DataGridViewRow row = gridView.Rows.Cast<DataGridViewRow>()
				.FirstOrDefault(r => r.Cells[COLUMN_FULL_NAME].Value.ToString().Equals(searchName));
#pragma warning restore CS8600 // ѕреобразование литерала, допускающего значение NULL или возможного значени€ NULL в тип, не допускающий значение NULL.

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
				devInfo = $"[{result.VolumeLabel}] {Dir.GetSizeSuffix(result.TotalFreeSpace)} из {Dir.GetSizeSuffix(result.TotalSize)} свободно";
			}
			
			return devInfo;
		}
		
		private void ChangeDefaultDrive()
		{
			if (DeviceList.Count > 0)
			{
				comboBoxDevicesLeft.SelectedIndex = 0;
				comboBoxDevicesRight.SelectedIndex = 0;
#pragma warning disable CS8602 // –азыменование веро€тной пустой ссылки.
				(toolStripDiskLeft.Items[0] as ToolStripButton).Checked = true;
#pragma warning restore CS8602 // –азыменование веро€тной пустой ссылки.
#pragma warning disable CS8602 // –азыменование веро€тной пустой ссылки.
				(toolStripDiskRight.Items[0] as ToolStripButton).Checked = true;
#pragma warning restore CS8602 // –азыменование веро€тной пустой ссылки.
			}
		}

		private void LoadDataGridView(DataGridView gridView, string path)
		{
			List<DirStructure> dirList = Dir.GetDirectoriesInfo(path);
			gridView.DataSource = dirList;
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

		#endregion

		#region —обыти€ формы

		private void Main_Load(object sender, EventArgs e)
		{
			InitialComboboxDevices();
		}

		private void dataGridViewLeft_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			CurrentSplit = Split.Left;

			if (e.Button == MouseButtons.Left && e.RowIndex >= 0)
			{
				OpenObject(dataGridViewLeft.Rows[e.RowIndex]);
			}
		}

		private void dataGridViewRight_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			CurrentSplit = Split.Right;

			if (e.Button == MouseButtons.Left && e.RowIndex >= 0)
			{
				OpenObject(dataGridViewRight.Rows[e.RowIndex]);
			}
		}

		private void comboBoxDevicesLeft_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (sender is ComboBox comboBox)
			{
				var deviceName = comboBox.SelectedItem.ToString()?.Substring(0, 1);

				if (!string.IsNullOrWhiteSpace(deviceName))
				{
					labelDeviceInfoLeft.Text = GetDriveInfo(deviceName);
					LoadDataGridView(dataGridViewLeft, $"{deviceName}:\\");
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
					labelDeviceInfoRight.Text = GetDriveInfo(deviceName);
					LoadDataGridView(dataGridViewRight, $"{deviceName}:\\");
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

		#endregion

		private void dataGridViewLeft_MouseDown(object sender, MouseEventArgs e)
		{
			
			
		}

		private void dataGridViewLeft_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				if (sender is DataGridView gridView)
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

		private void dataGridViewLeft_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				if (sender is DataGridView dataGrid)
				{
					var rows = dataGrid.SelectedRows;
					FileInfo[] arrFI = new FileInfo[rows.Count];

					for (var i = 0; i < rows.Count; i++)
					{
						var fullName = rows[i].Cells[COLUMN_FULL_NAME].Value.ToString() ?? "";

						if (!string.IsNullOrWhiteSpace(fullName))
						{
							arrFI[i] = new FileInfo(fullName);
						}
					}

					if (arrFI.Length > 0)
					{
						new ShellContextMenu().ShowContextMenu(arrFI, this.PointToScreen(new Point(e.X, e.Y)));
					}
				}
			}
		}
	}
}