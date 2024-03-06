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
	public partial class Signup : Form
	{
		private readonly IQuery<Admin> _iQuery;
		private const string AMDIN_CODE = "ADMIN";

		public Signup(IQuery<Admin> iQuery)
		{
			InitializeComponent();
			_iQuery = iQuery;
		}

		/// <summary>
		/// 회원가입 로직
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSignup_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbId.Text) || string.IsNullOrWhiteSpace(tbPassword.Text)
				|| string.IsNullOrWhiteSpace(tbAdminCode.Text))
			{
				MessageBox.Show("모든 항목을 입력해주세요.");
				return;
			}
			else
			{
				if (tbAdminCode.Text == Signup.AMDIN_CODE)
				{
					string adminId = tbId.Text;
					string password = PasswordUtil.HashingPassword(tbPassword.Text);

					Admin admin = new Admin()
					{
						AdminId = adminId,
						Password = password
					};

					_iQuery.Create(admin);
					Close();
				}
				else
				{
					MessageBox.Show("관리자 코드를 확인해주세요");
				}
			}
		}

		private void btnCancle_Click(object sender, EventArgs e)
		{
			Close();

		}
	}
}
