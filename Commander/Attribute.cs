using BL;

namespace Commander
{
	public partial class Attribute : Form
	{
		private List<AttributeStructure> _attributes = new List<AttributeStructure>();

		public Attribute()
		{
			InitializeComponent();
		}

		public Attribute(List<string> pathList) : this()
		{
			if (pathList == null || pathList.Count == 0)
			{
				throw new ArgumentNullException("Список объектов директории не может быть пустым", nameof(pathList));
			}

			foreach (var fullName in pathList)
			{
				_attributes.Add(new AttributeStructure()
				{
					FullName = fullName,
					Arhive = (File.GetAttributes(fullName) & FileAttributes.Archive) == FileAttributes.Archive,
					ReadOnly = (File.GetAttributes(fullName) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly,
					Hidden = (File.GetAttributes(fullName) & FileAttributes.Hidden) == FileAttributes.Hidden,
					System = (File.GetAttributes(fullName) & FileAttributes.System) == FileAttributes.System,
				});
			}

			chbArhive.CheckState = GetStatusAttribute(_attributes, FileAttributes.Archive);
			chbReadOnly.CheckState = GetStatusAttribute(_attributes, FileAttributes.ReadOnly);
			chbHidden.CheckState = GetStatusAttribute(_attributes, FileAttributes.Hidden);
			chbSystem.CheckState = GetStatusAttribute(_attributes, FileAttributes.System);

			if (pathList.Count == 1)
			{
				var date = File.GetLastWriteTime(pathList[0].ToString());
				LoadTextBoxDateTime(date);
			}
		}

		#region События формы

		private void btnDateTimeNow_Click(object sender, EventArgs e) => LoadTextBoxDateTime(DateTime.Now);

		private void btnCancel_Click(object sender, EventArgs e) => Close();

		private void btnOk_Click(object sender, EventArgs e)
		{
			foreach (var item in _attributes)
			{
				var searchOption = chbProcessContentsOfDir.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

				Dir.SetAttributes(item.FullName, FileAttributes.Archive, chbArhive.Checked, searchOption);
				Dir.SetAttributes(item.FullName, FileAttributes.ReadOnly, chbReadOnly.Checked, searchOption);
				Dir.SetAttributes(item.FullName, FileAttributes.Hidden, chbHidden.Checked, searchOption);
				Dir.SetAttributes(item.FullName, FileAttributes.System, chbSystem.Checked, searchOption);

				var date = Function.ParseDate(textBoxDate.Text, textBoxTime.Text);

				if (date != DateTime.MinValue)
				{
					File.SetLastWriteTime(item.FullName, date);
				}
			}

			Close();
		}

		private void btnDialogDateTime_Click(object sender, EventArgs e)
		{
			var date = Function.ParseDate(textBoxDate.Text, textBoxTime.Text);

			if (date != DateTime.MinValue)
			{
				var form = new ChangeDate(date);

				if (form.ShowDialog() == DialogResult.OK)
				{
					LoadTextBoxDateTime(form.GetValue());
				}
			}
			else
			{
				var form = new ChangeDate();
				form.SetValue(DateTime.Now);

				if (form.ShowDialog() == DialogResult.OK)
				{
					LoadTextBoxDateTime(form.GetValue());
				}
			}
		}

		#endregion

		#region Служебные процедуры и функции

		private CheckState GetStatusAttribute(in List<AttributeStructure> attributes, FileAttributes attr)
		{
			var result = new List<AttributeStructure>();

			switch (attr)
			{
				case FileAttributes.Archive:
					result = attributes.GroupBy(x => x.Arhive).Select(x => new AttributeStructure() { Arhive = x.Key }).ToList();

					if (result.Count > 1)
					{
						return CheckState.Indeterminate;
					}
					else
					{
						return result[0].Arhive ? CheckState.Checked : CheckState.Unchecked;
					}
				case FileAttributes.ReadOnly:
					result = attributes.GroupBy(x => x.ReadOnly).Select(x => new AttributeStructure() { ReadOnly = x.Key }).ToList();

					if (result.Count > 1)
					{
						return CheckState.Indeterminate;
					}
					else
					{
						return result[0].ReadOnly ? CheckState.Checked : CheckState.Unchecked;
					}
				case FileAttributes.Hidden:
					result = attributes.GroupBy(x => x.Hidden).Select(x => new AttributeStructure() { Hidden = x.Key }).ToList();

					if (result.Count > 1)
					{
						return CheckState.Indeterminate;
					}
					else
					{
						return result[0].Hidden ? CheckState.Checked : CheckState.Unchecked;
					}
				case FileAttributes.System:
					result = attributes.GroupBy(x => x.System).Select(x => new AttributeStructure() { System = x.Key }).ToList();

					if (result.Count > 1)
					{
						return CheckState.Indeterminate;
					}
					else
					{
						return result[0].System ? CheckState.Checked : CheckState.Unchecked;
					}
			}

			return CheckState.Unchecked;
		}

		private void LoadTextBoxDateTime(DateTime date)
		{
			textBoxDate.Text = date.ToString("dd.MM.yyyy");
			textBoxTime.Text = date.ToString("HH:mm:ss");
		}

		#endregion
	}
}
