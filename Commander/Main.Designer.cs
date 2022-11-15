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
			this.panelInfoSizeLeft = new System.Windows.Forms.Panel();
			this.labelDeviceInfoLeft = new System.Windows.Forms.Label();
			this.comboBoxDevicesLeft = new System.Windows.Forms.ComboBox();
			this.dirStructureBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panelInfoSizeRight = new System.Windows.Forms.Panel();
			this.labelDeviceInfoRight = new System.Windows.Forms.Label();
			this.comboBoxDevicesRight = new System.Windows.Forms.ComboBox();
			this.dataGridViewRight = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeObjectDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sizeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.attributeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewLeft = new System.Windows.Forms.DataGridView();
			this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeObjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.attributeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.toolStripDiskLeft = new System.Windows.Forms.ToolStrip();
			this.toolStripDiskRight = new System.Windows.Forms.ToolStrip();
			this.panelToolbar = new System.Windows.Forms.Panel();
			this.btnShowHidden = new System.Windows.Forms.Button();
			this.btnEditAttributes = new System.Windows.Forms.Button();
			this.panelInfoSizeLeft.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dirStructureBindingSource)).BeginInit();
			this.panelInfoSizeRight.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeft)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.panelToolbar.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelInfoSizeLeft
			// 
			this.panelInfoSizeLeft.Controls.Add(this.labelDeviceInfoLeft);
			this.panelInfoSizeLeft.Controls.Add(this.comboBoxDevicesLeft);
			this.panelInfoSizeLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelInfoSizeLeft.Location = new System.Drawing.Point(3, 38);
			this.panelInfoSizeLeft.Name = "panelInfoSizeLeft";
			this.panelInfoSizeLeft.Size = new System.Drawing.Size(517, 29);
			this.panelInfoSizeLeft.TabIndex = 2;
			// 
			// labelDeviceInfoLeft
			// 
			this.labelDeviceInfoLeft.AutoSize = true;
			this.labelDeviceInfoLeft.Location = new System.Drawing.Point(50, 6);
			this.labelDeviceInfoLeft.Name = "labelDeviceInfoLeft";
			this.labelDeviceInfoLeft.Size = new System.Drawing.Size(108, 15);
			this.labelDeviceInfoLeft.TabIndex = 1;
			this.labelDeviceInfoLeft.Text = "labelDeviceInfoLeft";
			// 
			// comboBoxDevicesLeft
			// 
			this.comboBoxDevicesLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDevicesLeft.DropDownWidth = 100;
			this.comboBoxDevicesLeft.FormattingEnabled = true;
			this.comboBoxDevicesLeft.Location = new System.Drawing.Point(3, 3);
			this.comboBoxDevicesLeft.Name = "comboBoxDevicesLeft";
			this.comboBoxDevicesLeft.Size = new System.Drawing.Size(41, 23);
			this.comboBoxDevicesLeft.TabIndex = 0;
			this.comboBoxDevicesLeft.SelectedIndexChanged += new System.EventHandler(this.comboBoxDevicesLeft_SelectedIndexChanged);
			// 
			// dirStructureBindingSource
			// 
			this.dirStructureBindingSource.DataSource = typeof(BL.DirStructure);
			// 
			// panelInfoSizeRight
			// 
			this.panelInfoSizeRight.Controls.Add(this.labelDeviceInfoRight);
			this.panelInfoSizeRight.Controls.Add(this.comboBoxDevicesRight);
			this.panelInfoSizeRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelInfoSizeRight.Location = new System.Drawing.Point(534, 38);
			this.panelInfoSizeRight.Name = "panelInfoSizeRight";
			this.panelInfoSizeRight.Size = new System.Drawing.Size(517, 29);
			this.panelInfoSizeRight.TabIndex = 2;
			// 
			// labelDeviceInfoRight
			// 
			this.labelDeviceInfoRight.AutoSize = true;
			this.labelDeviceInfoRight.Location = new System.Drawing.Point(50, 6);
			this.labelDeviceInfoRight.Name = "labelDeviceInfoRight";
			this.labelDeviceInfoRight.Size = new System.Drawing.Size(116, 15);
			this.labelDeviceInfoRight.TabIndex = 1;
			this.labelDeviceInfoRight.Text = "labelDeviceInfoRight";
			// 
			// comboBoxDevicesRight
			// 
			this.comboBoxDevicesRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDevicesRight.DropDownWidth = 100;
			this.comboBoxDevicesRight.FormattingEnabled = true;
			this.comboBoxDevicesRight.Location = new System.Drawing.Point(3, 3);
			this.comboBoxDevicesRight.Name = "comboBoxDevicesRight";
			this.comboBoxDevicesRight.Size = new System.Drawing.Size(41, 23);
			this.comboBoxDevicesRight.TabIndex = 0;
			this.comboBoxDevicesRight.SelectedIndexChanged += new System.EventHandler(this.comboBoxDevicesRight_SelectedIndexChanged);
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
            this.dataGridViewTextBoxColumn1,
            this.typeObjectDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn1,
            this.sizeDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn1,
            this.attributeDataGridViewTextBoxColumn1});
			this.dataGridViewRight.DataSource = this.dirStructureBindingSource;
			this.dataGridViewRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewRight.Location = new System.Drawing.Point(534, 73);
			this.dataGridViewRight.Name = "dataGridViewRight";
			this.dataGridViewRight.ReadOnly = true;
			this.dataGridViewRight.RowTemplate.Height = 25;
			this.dataGridViewRight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewRight.Size = new System.Drawing.Size(517, 505);
			this.dataGridViewRight.TabIndex = 1;
			this.dataGridViewRight.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
			this.dataGridViewRight.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
			this.dataGridViewRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseUp);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "FullName";
			this.dataGridViewTextBoxColumn1.HeaderText = "FullName";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// typeObjectDataGridViewTextBoxColumn1
			// 
			this.typeObjectDataGridViewTextBoxColumn1.DataPropertyName = "TypeObject";
			this.typeObjectDataGridViewTextBoxColumn1.HeaderText = "TypeObject";
			this.typeObjectDataGridViewTextBoxColumn1.Name = "typeObjectDataGridViewTextBoxColumn1";
			this.typeObjectDataGridViewTextBoxColumn1.ReadOnly = true;
			this.typeObjectDataGridViewTextBoxColumn1.Visible = false;
			// 
			// nameDataGridViewTextBoxColumn1
			// 
			this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn1.HeaderText = "Имя";
			this.nameDataGridViewTextBoxColumn1.MinimumWidth = 100;
			this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
			this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
			dataGridViewCellStyle1.Format = "G";
			dataGridViewCellStyle1.NullValue = null;
			this.dateDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
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
			// dataGridViewLeft
			// 
			this.dataGridViewLeft.AllowUserToAddRows = false;
			this.dataGridViewLeft.AllowUserToDeleteRows = false;
			this.dataGridViewLeft.AutoGenerateColumns = false;
			this.dataGridViewLeft.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewLeft.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dataGridViewLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewLeft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.typeObjectDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.attributeDataGridViewTextBoxColumn});
			this.dataGridViewLeft.DataSource = this.dirStructureBindingSource;
			this.dataGridViewLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewLeft.Location = new System.Drawing.Point(3, 73);
			this.dataGridViewLeft.Name = "dataGridViewLeft";
			this.dataGridViewLeft.ReadOnly = true;
			this.dataGridViewLeft.RowTemplate.Height = 25;
			this.dataGridViewLeft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewLeft.Size = new System.Drawing.Size(517, 505);
			this.dataGridViewLeft.TabIndex = 3;
			this.dataGridViewLeft.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
			this.dataGridViewLeft.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
			this.dataGridViewLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseUp);
			// 
			// FullName
			// 
			this.FullName.DataPropertyName = "FullName";
			this.FullName.HeaderText = "FullName";
			this.FullName.Name = "FullName";
			this.FullName.ReadOnly = true;
			this.FullName.Visible = false;
			// 
			// typeObjectDataGridViewTextBoxColumn
			// 
			this.typeObjectDataGridViewTextBoxColumn.DataPropertyName = "TypeObject";
			this.typeObjectDataGridViewTextBoxColumn.HeaderText = "TypeObject";
			this.typeObjectDataGridViewTextBoxColumn.Name = "typeObjectDataGridViewTextBoxColumn";
			this.typeObjectDataGridViewTextBoxColumn.ReadOnly = true;
			this.typeObjectDataGridViewTextBoxColumn.Visible = false;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
			this.nameDataGridViewTextBoxColumn.MinimumWidth = 100;
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
			dataGridViewCellStyle2.Format = "G";
			dataGridViewCellStyle2.NullValue = null;
			this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
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
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.panelInfoSizeLeft, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.dataGridViewRight, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.panelInfoSizeRight, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.dataGridViewLeft, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.toolStripDiskLeft, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.toolStripDiskRight, 2, 0);
			this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 64);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1054, 581);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// toolStripDiskLeft
			// 
			this.toolStripDiskLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripDiskLeft.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStripDiskLeft.Location = new System.Drawing.Point(0, 0);
			this.toolStripDiskLeft.Name = "toolStripDiskLeft";
			this.toolStripDiskLeft.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStripDiskLeft.Size = new System.Drawing.Size(523, 35);
			this.toolStripDiskLeft.TabIndex = 4;
			this.toolStripDiskLeft.Text = "toolStrip1";
			this.toolStripDiskLeft.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripDiskLeft_ItemClicked);
			// 
			// toolStripDiskRight
			// 
			this.toolStripDiskRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripDiskRight.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStripDiskRight.Location = new System.Drawing.Point(531, 0);
			this.toolStripDiskRight.Name = "toolStripDiskRight";
			this.toolStripDiskRight.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStripDiskRight.Size = new System.Drawing.Size(523, 35);
			this.toolStripDiskRight.TabIndex = 5;
			this.toolStripDiskRight.Text = "toolStrip2";
			this.toolStripDiskRight.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripDiskRight_ItemClicked);
			// 
			// panelToolbar
			// 
			this.panelToolbar.Controls.Add(this.btnShowHidden);
			this.panelToolbar.Controls.Add(this.btnEditAttributes);
			this.panelToolbar.Location = new System.Drawing.Point(12, 12);
			this.panelToolbar.Name = "panelToolbar";
			this.panelToolbar.Size = new System.Drawing.Size(1051, 46);
			this.panelToolbar.TabIndex = 5;
			// 
			// btnShowHidden
			// 
			this.btnShowHidden.Image = global::Commander.Properties.Resources.icons8_show_property_32;
			this.btnShowHidden.Location = new System.Drawing.Point(49, 3);
			this.btnShowHidden.Name = "btnShowHidden";
			this.btnShowHidden.Size = new System.Drawing.Size(40, 40);
			this.btnShowHidden.TabIndex = 0;
			this.btnShowHidden.UseVisualStyleBackColor = true;
			// 
			// btnEditAttributes
			// 
			this.btnEditAttributes.Image = global::Commander.Properties.Resources.icons8_edit_property_32;
			this.btnEditAttributes.Location = new System.Drawing.Point(3, 3);
			this.btnEditAttributes.Name = "btnEditAttributes";
			this.btnEditAttributes.Size = new System.Drawing.Size(40, 40);
			this.btnEditAttributes.TabIndex = 0;
			this.btnEditAttributes.UseVisualStyleBackColor = true;
			this.btnEditAttributes.Click += new System.EventHandler(this.btnEditAttributes_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1078, 657);
			this.Controls.Add(this.panelToolbar);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Main";
			this.Text = "My Commander";
			this.Load += new System.EventHandler(this.Main_Load);
			this.panelInfoSizeLeft.ResumeLayout(false);
			this.panelInfoSizeLeft.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dirStructureBindingSource)).EndInit();
			this.panelInfoSizeRight.ResumeLayout(false);
			this.panelInfoSizeRight.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeft)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.panelToolbar.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private DataGridView dataGridViewRight;
		private BindingSource dirStructureBindingSource;
		private Panel panelInfoSizeRight;
		private Label labelDeviceInfoRight;
		private ComboBox comboBoxDevicesRight;
		private Panel panelInfoSizeLeft;
		private Label labelDeviceInfoLeft;
		private ComboBox comboBoxDevicesLeft;
		private DataGridView dataGridViewLeft;
		private DataGridViewTextBoxColumn FullName;
		private DataGridViewTextBoxColumn typeObjectDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn attributeDataGridViewTextBoxColumn;
		private TableLayoutPanel tableLayoutPanel1;
		private ToolStrip toolStripDiskLeft;
		private ToolStrip toolStripDiskRight;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn typeObjectDataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn attributeDataGridViewTextBoxColumn1;
		private Panel panelToolbar;
		private Button btnEditAttributes;
		private Button btnShowHidden;
	}
}