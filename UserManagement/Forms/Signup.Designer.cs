namespace UserManagement.Forms
{
	partial class Signup
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
			tbPassword = new TextBox();
			label1 = new Label();
			label2 = new Label();
			tableLayoutPanel2 = new TableLayoutPanel();
			btnCancle = new Button();
			btnSignup = new Button();
			tbId = new TextBox();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(tbPassword, 0, 3);
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Controls.Add(label2, 0, 2);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 4);
			tableLayoutPanel1.Controls.Add(tbId, 0, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 5;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
			tableLayoutPanel1.Size = new Size(384, 461);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// tbPassword
			// 
			tbPassword.Dock = DockStyle.Fill;
			tbPassword.Location = new Point(3, 279);
			tbPassword.Name = "tbPassword";
			tbPassword.Size = new Size(378, 23);
			tbPassword.TabIndex = 4;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Left;
			label1.AutoSize = true;
			label1.Location = new Point(3, 38);
			label1.Name = "label1";
			label1.Size = new Size(19, 15);
			label1.TabIndex = 0;
			label1.Text = "ID";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Left;
			label2.AutoSize = true;
			label2.Location = new Point(3, 222);
			label2.Name = "label2";
			label2.Size = new Size(57, 15);
			label2.TabIndex = 1;
			label2.Text = "Password";
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(btnCancle, 1, 0);
			tableLayoutPanel2.Controls.Add(btnSignup, 0, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 371);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(378, 87);
			tableLayoutPanel2.TabIndex = 2;
			// 
			// btnCancle
			// 
			btnCancle.Dock = DockStyle.Fill;
			btnCancle.Location = new Point(199, 10);
			btnCancle.Margin = new Padding(10);
			btnCancle.Name = "btnCancle";
			btnCancle.Size = new Size(169, 67);
			btnCancle.TabIndex = 1;
			btnCancle.Text = "Cancel";
			btnCancle.UseVisualStyleBackColor = true;
			btnCancle.Click += btnCancle_Click;
			// 
			// btnSignup
			// 
			btnSignup.Dock = DockStyle.Fill;
			btnSignup.Location = new Point(10, 10);
			btnSignup.Margin = new Padding(10);
			btnSignup.Name = "btnSignup";
			btnSignup.Size = new Size(169, 67);
			btnSignup.TabIndex = 0;
			btnSignup.Text = "Signup";
			btnSignup.UseVisualStyleBackColor = true;
			btnSignup.Click += btnSignup_Click;
			// 
			// tbId
			// 
			tbId.Dock = DockStyle.Fill;
			tbId.Location = new Point(3, 95);
			tbId.Name = "tbId";
			tbId.Size = new Size(378, 23);
			tbId.TabIndex = 3;
			// 
			// Signup
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(384, 461);
			Controls.Add(tableLayoutPanel1);
			Name = "Signup";
			Text = "Signup";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Label label1;
		private Label label2;
		private TextBox tbPassword;
		private TableLayoutPanel tableLayoutPanel2;
		private Button btnCancle;
		private Button btnSignup;
		private TextBox tbId;
	}
}