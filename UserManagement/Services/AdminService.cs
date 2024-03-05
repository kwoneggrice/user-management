using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.IServices;
using UserManagement.Models;

namespace UserManagement.Services
{
	public class AdminService : IQuery<Admin>
	{
		private readonly UserManagementContext _userManagementContext;

		public AdminService(UserManagementContext userManagementContext)
		{
			_userManagementContext = userManagementContext;
		}

		public void Create(Admin entity)
		{
			_userManagementContext.Admins.Add(entity);
			_userManagementContext.SaveChanges();
		}

		public void Delete(long? id)
		{
			throw new NotImplementedException();
		}

		public List<Admin> GetAll()
		{
			throw new NotImplementedException();
		}

		public Admin GetOne(long? id)
		{
			throw new NotImplementedException();
		}

		public Admin GetOneByLoginId(string loginId)
		{
			var data = _userManagementContext.Admins.FirstOrDefault(x => x.AdminId == loginId);
			return data;
		}

		public void Update(Admin entity)
		{
			throw new NotImplementedException();
		}
	}
}
