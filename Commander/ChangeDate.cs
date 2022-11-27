using BL;

namespace Commander
{
	public partial class ChangeDate : Form
	{
		private DateTime _date;

		public ChangeDate()
		{
			InitializeComponent();
		}

		public ChangeDate(DateTime date) : this()
		{
			datePicker.Text = date.ToString("dd.MM.yyyy");
			timePicker.Text = date.ToString("HH:mm:ss");
		}

		private void btnCancel_Click(object sender, EventArgs e) => Close();

		private void btnOk_Click(object sender, EventArgs e)
		{
			_date = Function.JoinDateTime(datePicker.Value, timePicker.Value);
			Close();
		}

		public void SetValue(DateTime date) => _date = date;

		public DateTime GetValue() => _date;
	}
}
