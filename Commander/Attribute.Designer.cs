namespace Commander
{
	partial class Attribute
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.chbProcessContentsOfDir = new System.Windows.Forms.CheckBox();
			this.groupBoxEditAttributes = new System.Windows.Forms.GroupBox();
			this.chbSystem = new System.Windows.Forms.CheckBox();
			this.chbHidden = new System.Windows.Forms.CheckBox();
			this.chbReadOnly = new System.Windows.Forms.CheckBox();
			this.chbArhive = new System.Windows.Forms.CheckBox();
			this.groupBoxDateTime = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxTime = new System.Windows.Forms.TextBox();
			this.textBoxDate = new System.Windows.Forms.TextBox();
			this.btnDialogDateTime = new System.Windows.Forms.Button();
			this.btnDateTimeNow = new System.Windows.Forms.Button();
			this.chbEditDateTime = new System.Windows.Forms.CheckBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBoxEditAttributes.SuspendLayout();
			this.groupBoxDateTime.SuspendLayout();
			this.SuspendLayout();
			// 
			// chbProcessContentsOfDir
			// 
			this.chbProcessContentsOfDir.AutoSize = true;
			this.chbProcessContentsOfDir.Location = new System.Drawing.Point(12, 12);
			this.chbProcessContentsOfDir.Name = "chbProcessContentsOfDir";
			this.chbProcessContentsOfDir.Size = new System.Drawing.Size(236, 19);
			this.chbProcessContentsOfDir.TabIndex = 0;
			this.chbProcessContentsOfDir.Text = "Обрабатывать содержимое каталогов";
			this.chbProcessContentsOfDir.UseVisualStyleBackColor = true;
			// 
			// groupBoxEditAttributes
			// 
			this.groupBoxEditAttributes.Controls.Add(this.chbSystem);
			this.groupBoxEditAttributes.Controls.Add(this.chbHidden);
			this.groupBoxEditAttributes.Controls.Add(this.chbReadOnly);
			this.groupBoxEditAttributes.Controls.Add(this.chbArhive);
			this.groupBoxEditAttributes.Location = new System.Drawing.Point(12, 37);
			this.groupBoxEditAttributes.Name = "groupBoxEditAttributes";
			this.groupBoxEditAttributes.Size = new System.Drawing.Size(361, 129);
			this.groupBoxEditAttributes.TabIndex = 1;
			this.groupBoxEditAttributes.TabStop = false;
			this.groupBoxEditAttributes.Text = "Изменение атрибутов";
			// 
			// chbSystem
			// 
			this.chbSystem.AutoSize = true;
			this.chbSystem.Location = new System.Drawing.Point(6, 97);
			this.chbSystem.Name = "chbSystem";
			this.chbSystem.Size = new System.Drawing.Size(106, 19);
			this.chbSystem.TabIndex = 0;
			this.chbSystem.Text = "[&s] Системный";
			this.chbSystem.UseVisualStyleBackColor = true;
			// 
			// chbHidden
			// 
			this.chbHidden.AutoSize = true;
			this.chbHidden.Location = new System.Drawing.Point(6, 72);
			this.chbHidden.Name = "chbHidden";
			this.chbHidden.Size = new System.Drawing.Size(95, 19);
			this.chbHidden.TabIndex = 0;
			this.chbHidden.Text = "[&h] Скрытый";
			this.chbHidden.UseVisualStyleBackColor = true;
			// 
			// chbReadOnly
			// 
			this.chbReadOnly.AutoSize = true;
			this.chbReadOnly.Location = new System.Drawing.Point(6, 47);
			this.chbReadOnly.Name = "chbReadOnly";
			this.chbReadOnly.Size = new System.Drawing.Size(121, 19);
			this.chbReadOnly.TabIndex = 0;
			this.chbReadOnly.Text = "[&r] Только чтение";
			this.chbReadOnly.UseVisualStyleBackColor = true;
			// 
			// chbArhive
			// 
			this.chbArhive.AutoSize = true;
			this.chbArhive.Location = new System.Drawing.Point(6, 22);
			this.chbArhive.Name = "chbArhive";
			this.chbArhive.Size = new System.Drawing.Size(100, 19);
			this.chbArhive.TabIndex = 0;
			this.chbArhive.Text = "[&a] Архивный";
			this.chbArhive.UseVisualStyleBackColor = true;
			// 
			// groupBoxDateTime
			// 
			this.groupBoxDateTime.Controls.Add(this.label2);
			this.groupBoxDateTime.Controls.Add(this.label1);
			this.groupBoxDateTime.Controls.Add(this.textBoxTime);
			this.groupBoxDateTime.Controls.Add(this.textBoxDate);
			this.groupBoxDateTime.Controls.Add(this.btnDialogDateTime);
			this.groupBoxDateTime.Controls.Add(this.btnDateTimeNow);
			this.groupBoxDateTime.Controls.Add(this.chbEditDateTime);
			this.groupBoxDateTime.Location = new System.Drawing.Point(12, 172);
			this.groupBoxDateTime.Name = "groupBoxDateTime";
			this.groupBoxDateTime.Size = new System.Drawing.Size(361, 84);
			this.groupBoxDateTime.TabIndex = 2;
			this.groupBoxDateTime.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(162, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Время:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Дата:";
			// 
			// textBoxTime
			// 
			this.textBoxTime.Location = new System.Drawing.Point(213, 45);
			this.textBoxTime.Name = "textBoxTime";
			this.textBoxTime.ReadOnly = true;
			this.textBoxTime.Size = new System.Drawing.Size(100, 23);
			this.textBoxTime.TabIndex = 2;
			// 
			// textBoxDate
			// 
			this.textBoxDate.Location = new System.Drawing.Point(48, 46);
			this.textBoxDate.Name = "textBoxDate";
			this.textBoxDate.ReadOnly = true;
			this.textBoxDate.Size = new System.Drawing.Size(100, 23);
			this.textBoxDate.TabIndex = 2;
			// 
			// btnDialogDateTime
			// 
			this.btnDialogDateTime.Location = new System.Drawing.Point(319, 45);
			this.btnDialogDateTime.Name = "btnDialogDateTime";
			this.btnDialogDateTime.Size = new System.Drawing.Size(36, 23);
			this.btnDialogDateTime.TabIndex = 1;
			this.btnDialogDateTime.Text = ">>";
			this.btnDialogDateTime.UseVisualStyleBackColor = true;
			this.btnDialogDateTime.Click += new System.EventHandler(this.btnDialogDateTime_Click);
			// 
			// btnDateTimeNow
			// 
			this.btnDateTimeNow.Location = new System.Drawing.Point(280, 17);
			this.btnDateTimeNow.Name = "btnDateTimeNow";
			this.btnDateTimeNow.Size = new System.Drawing.Size(75, 23);
			this.btnDateTimeNow.TabIndex = 1;
			this.btnDateTimeNow.Text = "&Текущее";
			this.btnDateTimeNow.UseVisualStyleBackColor = true;
			this.btnDateTimeNow.Click += new System.EventHandler(this.btnDateTimeNow_Click);
			// 
			// chbEditDateTime
			// 
			this.chbEditDateTime.AutoSize = true;
			this.chbEditDateTime.Location = new System.Drawing.Point(7, 20);
			this.chbEditDateTime.Name = "chbEditDateTime";
			this.chbEditDateTime.Size = new System.Drawing.Size(173, 19);
			this.chbEditDateTime.TabIndex = 0;
			this.chbEditDateTime.Text = "Изменение даты/времени:";
			this.chbEditDateTime.UseVisualStyleBackColor = true;
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(112, 264);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(72, 24);
			this.btnOk.TabIndex = 3;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(192, 264);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(72, 24);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// Attribute
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(385, 297);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.groupBoxDateTime);
			this.Controls.Add(this.groupBoxEditAttributes);
			this.Controls.Add(this.chbProcessContentsOfDir);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Attribute";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Изменение атрибутов";
			this.groupBoxEditAttributes.ResumeLayout(false);
			this.groupBoxEditAttributes.PerformLayout();
			this.groupBoxDateTime.ResumeLayout(false);
			this.groupBoxDateTime.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CheckBox chbProcessContentsOfDir;
		private GroupBox groupBoxEditAttributes;
		private CheckBox chbSystem;
		private CheckBox chbHidden;
		private CheckBox chbReadOnly;
		private CheckBox chbArhive;
		private GroupBox groupBoxDateTime;
		private Label label2;
		private Label label1;
		private TextBox textBoxTime;
		private TextBox textBoxDate;
		private Button btnDialogDateTime;
		private Button btnDateTimeNow;
		private CheckBox chbEditDateTime;
		private Button btnOk;
		private Button btnCancel;
	}
}