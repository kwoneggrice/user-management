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
using UserManagement.Services;

namespace UserManagement.Forms
{
	public partial class DashBoard : Form
	{
		private readonly IQuery<User> _iQuery;
		private readonly UserCreate _userCreate;
		private readonly UserUpdate _userUpdate;

		public DashBoard(IQuery<User> iQuery, UserCreate userCreate, UserUpdate userUpdate)
		{
			InitializeComponent();
			_iQuery = iQuery;
			_userCreate = userCreate;
			_userUpdate = userUpdate;
		}

		public void RefreshDataTable()
		{
			var datas = _iQuery.GetAll();
			dgvDataTable.DataSource = datas;
		}

		public long GetEntityId()
		{
			long targetId = Convert.ToInt64(dgvDataTable.SelectedRows[0].Cells[0].Value.ToString());
			return targetId;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			RefreshDataTable();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			_userCreate.ShowDialog();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			long targetId = GetEntityId();
			_iQuery.Delete(targetId);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			long targetId = GetEntityId();

			var data = _iQuery.GetOne(targetId);

			_userUpdate.UserInfo = data;

			_userUpdate.ShowDialog();
		}
	}
}
