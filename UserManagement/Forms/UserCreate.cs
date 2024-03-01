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
	public partial class UserCreate : Form
	{
		private IQuery<User> _iQuery;

		public UserCreate(IQuery<User> iQuery)
		{
			InitializeComponent();
			_iQuery = iQuery;
		}

		private void btnCreate_Click(object sender, EventArgs e)
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

			User user = new User()
			{
				Username = tbUsername.Text,
				Phone = tbPhone.Text,
				Lesson = cbLesson.Text,
				Gender = gender
			};

			_iQuery.Create(user);
		}
	}
}
