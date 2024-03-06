namespace UserManagement.Forms
{
	partial class Login
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
			tableLayoutPanel2 = new TableLayoutPanel();
			btnSignup = new Button();
			tbPassword = new TextBox();
			label1 = new Label();
			label2 = new Label();
			tbId = new TextBox();
			btnLogin = new Button();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(361, 461);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Controls.Add(btnSignup, 0, 5);
			tableLayoutPanel2.Controls.Add(tbPassword, 0, 3);
			tableLayoutPanel2.Controls.Add(label1, 0, 0);
			tableLayoutPanel2.Controls.Add(label2, 0, 2);
			tableLayoutPanel2.Controls.Add(tbId, 0, 1);
			tableLayoutPanel2.Controls.Add(btnLogin, 0, 4);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 3);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 6;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666718F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
			tableLayoutPanel2.Size = new Size(355, 455);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// btnSignup
			// 
			btnSignup.Dock = DockStyle.Fill;
			btnSignup.Location = new Point(10, 385);
			btnSignup.Margin = new Padding(10);
			btnSignup.Name = "btnSignup";
			btnSignup.Size = new Size(335, 60);
			btnSignup.TabIndex = 5;
			btnSignup.Text = "Signup";
			btnSignup.UseVisualStyleBackColor = true;
			btnSignup.Click += btnSignup_Click;
			// 
			// tbPassword
			// 
			tbPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbPassword.Location = new Point(10, 251);
			tbPassword.Margin = new Padding(10);
			tbPassword.Name = "tbPassword";
			tbPassword.PasswordChar = '*';
			tbPassword.Size = new Size(335, 23);
			tbPassword.TabIndex = 3;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Left;
			label1.AutoSize = true;
			label1.Location = new Point(10, 30);
			label1.Margin = new Padding(10);
			label1.Name = "label1";
			label1.Size = new Size(19, 15);
			label1.TabIndex = 0;
			label1.Text = "ID";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Left;
			label2.AutoSize = true;
			label2.Location = new Point(10, 180);
			label2.Margin = new Padding(10);
			label2.Name = "label2";
			label2.Size = new Size(57, 15);
			label2.TabIndex = 1;
			label2.Text = "Password";
			// 
			// tbId
			// 
			tbId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbId.Location = new Point(10, 101);
			tbId.Margin = new Padding(10);
			tbId.Name = "tbId";
			tbId.Size = new Size(335, 23);
			tbId.TabIndex = 2;
			// 
			// btnLogin
			// 
			btnLogin.Dock = DockStyle.Fill;
			btnLogin.Location = new Point(10, 310);
			btnLogin.Margin = new Padding(10);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(335, 55);
			btnLogin.TabIndex = 4;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(361, 461);
			Controls.Add(tableLayoutPanel1);
			Name = "Login";
			Text = "Login";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private Label label1;
		private Label label2;
		private TextBox tbId;
		private Button btnSignup;
		private TextBox tbPassword;
		private Button btnLogin;
	}
}