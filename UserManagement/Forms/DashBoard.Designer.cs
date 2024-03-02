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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			tableLayoutPanel4 = new TableLayoutPanel();
			btnLessonRefresh = new Button();
			pieChartLesson = new System.Windows.Forms.DataVisualization.Charting.Chart();
			pieChartGender = new System.Windows.Forms.DataVisualization.Charting.Chart();
			btnGenderRefresh = new Button();
			tabPage2 = new TabPage();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			btnDelete = new Button();
			btnUpdate = new Button();
			btnCreate = new Button();
			btnSearch = new Button();
			tableLayoutPanel3 = new TableLayoutPanel();
			dgvDataTable = new DataGridView();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pieChartLesson).BeginInit();
			((System.ComponentModel.ISupportInitialize)pieChartGender).BeginInit();
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
			tabPage1.Controls.Add(tableLayoutPanel4);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(792, 422);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "DashBoard";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel4
			// 
			tableLayoutPanel4.ColumnCount = 2;
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel4.Controls.Add(btnLessonRefresh, 1, 1);
			tableLayoutPanel4.Controls.Add(pieChartLesson, 1, 0);
			tableLayoutPanel4.Controls.Add(pieChartGender, 0, 0);
			tableLayoutPanel4.Controls.Add(btnGenderRefresh, 0, 1);
			tableLayoutPanel4.Dock = DockStyle.Fill;
			tableLayoutPanel4.Location = new Point(3, 3);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 2;
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
			tableLayoutPanel4.Size = new Size(786, 416);
			tableLayoutPanel4.TabIndex = 0;
			// 
			// btnLessonRefresh
			// 
			btnLessonRefresh.Dock = DockStyle.Fill;
			btnLessonRefresh.Location = new Point(403, 366);
			btnLessonRefresh.Margin = new Padding(10);
			btnLessonRefresh.Name = "btnLessonRefresh";
			btnLessonRefresh.Size = new Size(373, 40);
			btnLessonRefresh.TabIndex = 3;
			btnLessonRefresh.Text = "Refresh";
			btnLessonRefresh.UseVisualStyleBackColor = true;
			// 
			// pieChartLesson
			// 
			chartArea3.Name = "ChartArea1";
			pieChartLesson.ChartAreas.Add(chartArea3);
			pieChartLesson.Dock = DockStyle.Fill;
			legend3.Name = "Legend1";
			pieChartLesson.Legends.Add(legend3);
			pieChartLesson.Location = new Point(403, 10);
			pieChartLesson.Margin = new Padding(10);
			pieChartLesson.Name = "pieChartLesson";
			series3.ChartArea = "ChartArea1";
			series3.Legend = "Legend1";
			series3.Name = "Series1";
			pieChartLesson.Series.Add(series3);
			pieChartLesson.Size = new Size(373, 336);
			pieChartLesson.TabIndex = 1;
			pieChartLesson.Text = "chart2";
			// 
			// pieChartGender
			// 
			chartArea4.Name = "ChartArea1";
			pieChartGender.ChartAreas.Add(chartArea4);
			pieChartGender.Dock = DockStyle.Fill;
			legend4.Name = "Legend1";
			pieChartGender.Legends.Add(legend4);
			pieChartGender.Location = new Point(10, 10);
			pieChartGender.Margin = new Padding(10);
			pieChartGender.Name = "pieChartGender";
			series4.ChartArea = "ChartArea1";
			series4.Legend = "Legend1";
			series4.Name = "Series1";
			pieChartGender.Series.Add(series4);
			pieChartGender.Size = new Size(373, 336);
			pieChartGender.TabIndex = 0;
			pieChartGender.Text = "chart1";
			// 
			// btnGenderRefresh
			// 
			btnGenderRefresh.Dock = DockStyle.Fill;
			btnGenderRefresh.Location = new Point(10, 366);
			btnGenderRefresh.Margin = new Padding(10);
			btnGenderRefresh.Name = "btnGenderRefresh";
			btnGenderRefresh.Size = new Size(373, 40);
			btnGenderRefresh.TabIndex = 2;
			btnGenderRefresh.Text = "Refresh";
			btnGenderRefresh.UseVisualStyleBackColor = true;
			btnGenderRefresh.Click += btnGenderRefresh_Click;
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
			btnDelete.Click += btnDelete_Click;
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
			btnUpdate.Click += btnUpdate_Click;
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
			btnCreate.Click += btnCreate_Click;
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
			btnSearch.Click += btnSearch_Click;
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
			dgvDataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
			tabPage1.ResumeLayout(false);
			tableLayoutPanel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pieChartLesson).EndInit();
			((System.ComponentModel.ISupportInitialize)pieChartGender).EndInit();
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
		private TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.DataVisualization.Charting.Chart pieChartLesson;
		private System.Windows.Forms.DataVisualization.Charting.Chart pieChartGender;
		private Button btnLessonRefresh;
		private Button btnGenderRefresh;
	}
}