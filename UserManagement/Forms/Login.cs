using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagement.IServices;
using UserManagement.Models;
using UserManagement.Utils;

namespace UserManagement.Forms
{
	public partial class Login : Form
	{
		private readonly Signup _signup;
		private readonly IQuery<Admin> _iQuery;

		public Login(Signup signup, IQuery<Admin> iQuery)
		{
			InitializeComponent();
			_signup = signup;
			_iQuery = iQuery;
		}

		private void btnSignup_Click(object sender, EventArgs e)
		{
			_signup.ShowDialog();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string adminId = tbId.Text;
			string password = PasswordUtil.HashingPassword(tbPassword.Text);

			var data = _iQuery.GetOneByLoginId(adminId);

			if (password.Equals(data.Password))
			{
				Program.isLogin = true;
				Close();
			}
			else
			{
				MessageBox.Show("입력하신 정보가 일치하지 않습니다.");
			}
			
		}
	}
}
