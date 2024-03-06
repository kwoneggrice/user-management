namespace UserManagement.Forms
{
	partial class UserCreate
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
			tableLayoutPanel1 = new TableLayoutPanel();
			tbPhone = new TextBox();
			tableLayoutPanel2 = new TableLayoutPanel();
			btnCancle = new Button();
			btnCreate = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			tableLayoutPanel3 = new TableLayoutPanel();
			rdbMale = new RadioButton();
			rdbFemale = new RadioButton();
			tbUsername = new TextBox();
			cbLesson = new ComboBox();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Controls.Add(tbPhone, 0, 3);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 8);
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Controls.Add(label2, 0, 2);
			tableLayoutPanel1.Controls.Add(label3, 0, 4);
			tableLayoutPanel1.Controls.Add(label4, 0, 6);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 7);
			tableLayoutPanel1.Controls.Add(tbUsername, 0, 1);
			tableLayoutPanel1.Controls.Add(cbLesson, 0, 5);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 9;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel1.Size = new Size(350, 447);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// tbPhone
			// 
			tbPhone.Dock = DockStyle.Fill;
			tbPhone.Location = new Point(3, 150);
			tbPhone.Name = "tbPhone";
			tbPhone.Size = new Size(344, 23);
			tbPhone.TabIndex = 7;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(btnCancle, 1, 0);
			tableLayoutPanel2.Controls.Add(btnCreate, 0, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 395);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(344, 49);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// btnCancle
			// 
			btnCancle.Dock = DockStyle.Fill;
			btnCancle.Location = new Point(175, 3);
			btnCancle.Name = "btnCancle";
			btnCancle.Size = new Size(166, 43);
			btnCancle.TabIndex = 1;
			btnCancle.Text = "Cancle";
			btnCancle.UseVisualStyleBackColor = true;
			btnCancle.Click += btnCancle_Click;
			// 
			// btnCreate
			// 
			btnCreate.Dock = DockStyle.Fill;
			btnCreate.Location = new Point(3, 3);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(166, 43);
			btnCreate.TabIndex = 0;
			btnCreate.Text = "Create";
			btnCreate.UseVisualStyleBackColor = true;
			btnCreate.Click += btnCreate_Click;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Left;
			label1.AutoSize = true;
			label1.Location = new Point(3, 17);
			label1.Name = "label1";
			label1.Size = new Size(31, 15);
			label1.TabIndex = 1;
			label1.Text = "이름";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Left;
			label2.AutoSize = true;
			label2.Location = new Point(3, 115);
			label2.Name = "label2";
			label2.Size = new Size(55, 15);
			label2.TabIndex = 2;
			label2.Text = "전화번호";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Left;
			label3.AutoSize = true;
			label3.Location = new Point(3, 213);
			label3.Name = "label3";
			label3.Size = new Size(31, 15);
			label3.TabIndex = 3;
			label3.Text = "강의";
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.Left;
			label4.AutoSize = true;
			label4.Location = new Point(3, 311);
			label4.Name = "label4";
			label4.Size = new Size(31, 15);
			label4.TabIndex = 4;
			label4.Text = "성별";
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 2;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Controls.Add(rdbMale, 0, 0);
			tableLayoutPanel3.Controls.Add(rdbFemale, 1, 0);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(3, 346);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 1;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Size = new Size(344, 43);
			tableLayoutPanel3.TabIndex = 5;
			// 
			// rdbMale
			// 
			rdbMale.Anchor = AnchorStyles.None;
			rdbMale.AutoSize = true;
			rdbMale.Location = new Point(61, 12);
			rdbMale.Name = "rdbMale";
			rdbMale.Size = new Size(49, 19);
			rdbMale.TabIndex = 0;
			rdbMale.TabStop = true;
			rdbMale.Text = "남성";
			rdbMale.UseVisualStyleBackColor = true;
			// 
			// rdbFemale
			// 
			rdbFemale.Anchor = AnchorStyles.None;
			rdbFemale.AutoSize = true;
			rdbFemale.Location = new Point(233, 12);
			rdbFemale.Name = "rdbFemale";
			rdbFemale.Size = new Size(49, 19);
			rdbFemale.TabIndex = 1;
			rdbFemale.TabStop = true;
			rdbFemale.Text = "여성";
			rdbFemale.UseVisualStyleBackColor = true;
			// 
			// tbUsername
			// 
			tbUsername.Dock = DockStyle.Fill;
			tbUsername.Location = new Point(3, 52);
			tbUsername.Name = "tbUsername";
			tbUsername.Size = new Size(344, 23);
			tbUsername.TabIndex = 6;
			// 
			// cbLesson
			// 
			cbLesson.Dock = DockStyle.Fill;
			cbLesson.DropDownStyle = ComboBoxStyle.DropDownList;
			cbLesson.FormattingEnabled = true;
			cbLesson.Items.AddRange(new object[] { "C#", "C++", "C", "Java", "Python" });
			cbLesson.Location = new Point(3, 248);
			cbLesson.Name = "cbLesson";
			cbLesson.Size = new Size(344, 23);
			cbLesson.TabIndex = 8;
			// 
			// UserCreate
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(350, 447);
			Controls.Add(tableLayoutPanel1);
			Name = "UserCreate";
			Text = "UserCreate";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private TextBox tbPhone;
		private TableLayoutPanel tableLayoutPanel2;
		private Button btnCancle;
		private Button btnCreate;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TableLayoutPanel tableLayoutPanel3;
		private RadioButton rdbMale;
		private RadioButton rdbFemale;
		private TextBox tbUsername;
		private ComboBox cbLesson;
	}
}