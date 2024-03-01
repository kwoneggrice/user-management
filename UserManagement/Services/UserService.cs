using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.IServices;
using UserManagement.Models;

namespace UserManagement.Services
{
	public class UserService : IQuery<User>
	{
		private readonly UserManagementContext _userManagementContext;

		public UserService(UserManagementContext userManagementContext)
		{
			_userManagementContext = userManagementContext;
		}

		public void Create(User entity)
		{
			_userManagementContext.Users.Add(entity);
			_userManagementContext.SaveChanges();
		}

		public void Delete(int id)
		{
			var data = _userManagementContext.Users.FirstOrDefault(x => x.Id == id);

			if (data != null)
			{
				_userManagementContext.Remove(data);
				_userManagementContext.SaveChanges();
			}
			else
			{
				throw new InvalidOperationException();
			}
		}

		public List<User> GetAll()
		{
			return _userManagementContext.Users.ToList();
		}

		public User GetOne(int id)
		{
			var data = _userManagementContext.Users.FirstOrDefault(x => x.Id == id);

			if (data != null)
			{
				return data;
			}
			else
			{
				throw new InvalidOperationException();

			}
		}

		public void Update(User entity)
		{
			_userManagementContext.Users.Update(entity);
			_userManagementContext.SaveChanges();
		}
	}
}
