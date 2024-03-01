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

namespace UserManagement.Forms
{
	public partial class UserUpdate : Form
	{
		private readonly IQuery<User> _iQuery;

		public UserUpdate(IQuery<User> iQuery)
		{
			InitializeComponent();
			_iQuery = iQuery;
		}

		public User UserInfo { get; set; }

		private void UserUpdate_Load(object sender, EventArgs e)
		{
			tbUsername.Text = UserInfo.Username;
			tbPhone.Text = UserInfo.Phone;
			cbLesson.Text = UserInfo.Lesson;
			if (UserInfo.Gender.Equals("남성"))
			{
				rdbMale.Checked = true;
			}
			else
			{
				rdbFemale.Checked = true;
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string gender = "";

			if (rdbMale.Checked == true)
			{
				gender = "남성";
			}
			else
			{
				gender = "여성";
			}

			UserInfo.Username = tbUsername.Text;
			UserInfo.Phone = tbPhone.Text;
			UserInfo.Lesson = cbLesson.Text;
			UserInfo.Gender = gender;

			_iQuery.Update(UserInfo);
		}
	}
}
