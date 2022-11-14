namespace Commander
{
	partial class Main
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.dataGridViewLeft = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.attributeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeObjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dirStructureBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewRight = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sizeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.attributeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeObjectDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeft)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dirStructureBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRight)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer
			// 
			this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer.Location = new System.Drawing.Point(12, 12);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.dataGridViewLeft);
			this.splitContainer.Panel1MinSize = 50;
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.dataGridViewRight);
			this.splitContainer.Panel2MinSize = 50;
			this.splitContainer.Size = new System.Drawing.Size(776, 426);
			this.splitContainer.SplitterDistance = 378;
			this.splitContainer.SplitterWidth = 8;
			this.splitContainer.TabIndex = 1;
			// 
			// dataGridViewLeft
			// 
			this.dataGridViewLeft.AllowUserToAddRows = false;
			this.dataGridViewLeft.AllowUserToDeleteRows = false;
			this.dataGridViewLeft.AutoGenerateColumns = false;
			this.dataGridViewLeft.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewLeft.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dataGridViewLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewLeft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.FullName,
            this.typeDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.attributeDataGridViewTextBoxColumn,
            this.typeObjectDataGridViewTextBoxColumn});
			this.dataGridViewLeft.DataSource = this.dirStructureBindingSource;
			this.dataGridViewLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewLeft.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewLeft.Name = "dataGridViewLeft";
			this.dataGridViewLeft.ReadOnly = true;
			this.dataGridViewLeft.RowTemplate.Height = 25;
			this.dataGridViewLeft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewLeft.Size = new System.Drawing.Size(378, 426);
			this.dataGridViewLeft.TabIndex = 0;
			this.dataGridViewLeft.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLeft_CellContentDoubleClick);
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
			this.nameDataGridViewTextBoxColumn.MinimumWidth = 100;
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// FullName
			// 
			this.FullName.DataPropertyName = "FullName";
			this.FullName.HeaderText = "FullName";
			this.FullName.Name = "FullName";
			this.FullName.ReadOnly = true;
			this.FullName.Visible = false;
			// 
			// typeDataGridViewTextBoxColumn
			// 
			this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
			this.typeDataGridViewTextBoxColumn.HeaderText = "Тип";
			this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
			this.typeDataGridViewTextBoxColumn.ReadOnly = true;
			this.typeDataGridViewTextBoxColumn.Width = 52;
			// 
			// sizeDataGridViewTextBoxColumn
			// 
			this.sizeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
			this.sizeDataGridViewTextBoxColumn.HeaderText = "Размер";
			this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
			this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
			this.sizeDataGridViewTextBoxColumn.Width = 72;
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			dataGridViewCellStyle1.Format = "G";
			dataGridViewCellStyle1.NullValue = null;
			this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
			this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			this.dateDataGridViewTextBoxColumn.ReadOnly = true;
			this.dateDataGridViewTextBoxColumn.Width = 57;
			// 
			// attributeDataGridViewTextBoxColumn
			// 
			this.attributeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.attributeDataGridViewTextBoxColumn.DataPropertyName = "Attribute";
			this.attributeDataGridViewTextBoxColumn.HeaderText = "Атрибуты";
			this.attributeDataGridViewTextBoxColumn.Name = "attributeDataGridViewTextBoxColumn";
			this.attributeDataGridViewTextBoxColumn.ReadOnly = true;
			this.attributeDataGridViewTextBoxColumn.Width = 86;
			// 
			// typeObjectDataGridViewTextBoxColumn
			// 
			this.typeObjectDataGridViewTextBoxColumn.DataPropertyName = "TypeObject";
			this.typeObjectDataGridViewTextBoxColumn.HeaderText = "TypeObject";
			this.typeObjectDataGridViewTextBoxColumn.Name = "typeObjectDataGridViewTextBoxColumn";
			this.typeObjectDataGridViewTextBoxColumn.ReadOnly = true;
			this.typeObjectDataGridViewTextBoxColumn.Visible = false;
			// 
			// dirStructureBindingSource
			// 
			this.dirStructureBindingSource.DataSource = typeof(BL.DirStructure);
			// 
			// dataGridViewRight
			// 
			this.dataGridViewRight.AllowUserToAddRows = false;
			this.dataGridViewRight.AllowUserToDeleteRows = false;
			this.dataGridViewRight.AutoGenerateColumns = false;
			this.dataGridViewRight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewRight.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dataGridViewRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewRight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn1,
            this.sizeDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn1,
            this.attributeDataGridViewTextBoxColumn1,
            this.typeObjectDataGridViewTextBoxColumn1});
			this.dataGridViewRight.DataSource = this.dirStructureBindingSource;
			this.dataGridViewRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewRight.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewRight.Name = "dataGridViewRight";
			this.dataGridViewRight.ReadOnly = true;
			this.dataGridViewRight.RowTemplate.Height = 25;
			this.dataGridViewRight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewRight.Size = new System.Drawing.Size(390, 426);
			this.dataGridViewRight.TabIndex = 1;
			this.dataGridViewRight.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRight_CellContentDoubleClick);
			// 
			// nameDataGridViewTextBoxColumn1
			// 
			this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn1.HeaderText = "Имя";
			this.nameDataGridViewTextBoxColumn1.MinimumWidth = 100;
			this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
			this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn1.HeaderText = "FullName";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// typeDataGridViewTextBoxColumn1
			// 
			this.typeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
			this.typeDataGridViewTextBoxColumn1.HeaderText = "Тип";
			this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
			this.typeDataGridViewTextBoxColumn1.ReadOnly = true;
			this.typeDataGridViewTextBoxColumn1.Width = 52;
			// 
			// sizeDataGridViewTextBoxColumn1
			// 
			this.sizeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.sizeDataGridViewTextBoxColumn1.DataPropertyName = "Size";
			this.sizeDataGridViewTextBoxColumn1.HeaderText = "Размер";
			this.sizeDataGridViewTextBoxColumn1.Name = "sizeDataGridViewTextBoxColumn1";
			this.sizeDataGridViewTextBoxColumn1.ReadOnly = true;
			this.sizeDataGridViewTextBoxColumn1.Width = 72;
			// 
			// dateDataGridViewTextBoxColumn1
			// 
			this.dateDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
			dataGridViewCellStyle2.Format = "G";
			dataGridViewCellStyle2.NullValue = null;
			this.dateDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dateDataGridViewTextBoxColumn1.HeaderText = "Дата";
			this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
			this.dateDataGridViewTextBoxColumn1.ReadOnly = true;
			this.dateDataGridViewTextBoxColumn1.Width = 57;
			// 
			// attributeDataGridViewTextBoxColumn1
			// 
			this.attributeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.attributeDataGridViewTextBoxColumn1.DataPropertyName = "Attribute";
			this.attributeDataGridViewTextBoxColumn1.HeaderText = "Атрибуты";
			this.attributeDataGridViewTextBoxColumn1.Name = "attributeDataGridViewTextBoxColumn1";
			this.attributeDataGridViewTextBoxColumn1.ReadOnly = true;
			this.attributeDataGridViewTextBoxColumn1.Width = 86;
			// 
			// typeObjectDataGridViewTextBoxColumn1
			// 
			this.typeObjectDataGridViewTextBoxColumn1.DataPropertyName = "TypeObject";
			this.typeObjectDataGridViewTextBoxColumn1.HeaderText = "TypeObject";
			this.typeObjectDataGridViewTextBoxColumn1.Name = "typeObjectDataGridViewTextBoxColumn1";
			this.typeObjectDataGridViewTextBoxColumn1.ReadOnly = true;
			this.typeObjectDataGridViewTextBoxColumn1.Visible = false;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.splitContainer);
			this.Name = "Main";
			this.Text = "My Commander";
			this.Load += new System.EventHandler(this.Main_Load);
			this.Resize += new System.EventHandler(this.Main_Resize);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeft)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dirStructureBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRight)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private SplitContainer splitContainer;
		private DataGridView dataGridViewLeft;
		private DataGridView dataGridViewRight;
		private BindingSource dirStructureBindingSource;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn FullName;
		private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn attributeDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn typeObjectDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn attributeDataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn typeObjectDataGridViewTextBoxColumn1;
	}
}