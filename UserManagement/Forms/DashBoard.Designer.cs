namespace UserManagement.Forms
{
	partial class DashBoard
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
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			tabPage2 = new TabPage();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			btnSearch = new Button();
			btnCreate = new Button();
			btnUpdate = new Button();
			btnDelete = new Button();
			tableLayoutPanel3 = new TableLayoutPanel();
			dgvDataTable = new DataGridView();
			tabControl1.SuspendLayout();
			tabPage2.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvDataTable).BeginInit();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(800, 450);
			tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(792, 422);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "DashBoard";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(tableLayoutPanel1);
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(792, 422);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "회원 관리";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(3, 3);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 78.60577F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.39423F));
			tableLayoutPanel1.Size = new Size(786, 416);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 4;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel2.Controls.Add(btnDelete, 3, 0);
			tableLayoutPanel2.Controls.Add(btnUpdate, 2, 0);
			tableLayoutPanel2.Controls.Add(btnCreate, 1, 0);
			tableLayoutPanel2.Controls.Add(btnSearch, 0, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 329);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Size = new Size(780, 84);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// btnSearch
			// 
			btnSearch.Dock = DockStyle.Fill;
			btnSearch.Location = new Point(10, 10);
			btnSearch.Margin = new Padding(10);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(175, 64);
			btnSearch.TabIndex = 0;
			btnSearch.Text = "Search";
			btnSearch.UseVisualStyleBackColor = true;
			// 
			// btnCreate
			// 
			btnCreate.Dock = DockStyle.Fill;
			btnCreate.Location = new Point(205, 10);
			btnCreate.Margin = new Padding(10);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(175, 64);
			btnCreate.TabIndex = 1;
			btnCreate.Text = "Create";
			btnCreate.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			btnUpdate.Dock = DockStyle.Fill;
			btnUpdate.Location = new Point(400, 10);
			btnUpdate.Margin = new Padding(10);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(175, 64);
			btnUpdate.TabIndex = 2;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			btnDelete.Dock = DockStyle.Fill;
			btnDelete.Location = new Point(595, 10);
			btnDelete.Margin = new Padding(10);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(175, 64);
			btnDelete.TabIndex = 3;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 1;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Controls.Add(dgvDataTable, 0, 0);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(3, 3);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 1;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Size = new Size(780, 320);
			tableLayoutPanel3.TabIndex = 1;
			// 
			// dgvDataTable
			// 
			dgvDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDataTable.Dock = DockStyle.Fill;
			dgvDataTable.Location = new Point(10, 10);
			dgvDataTable.Margin = new Padding(10);
			dgvDataTable.Name = "dgvDataTable";
			dgvDataTable.Size = new Size(760, 300);
			dgvDataTable.TabIndex = 0;
			// 
			// DashBoard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tabControl1);
			Name = "DashBoard";
			Text = "DashBoard";
			tabControl1.ResumeLayout(false);
			tabPage2.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvDataTable).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private Button btnDelete;
		private Button btnUpdate;
		private Button btnCreate;
		private Button btnSearch;
		private TableLayoutPanel tableLayoutPanel3;
		private DataGridView dgvDataTable;
	}
}