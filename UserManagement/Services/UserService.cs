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

		/// <summary>
		/// 테이블에 값을 추가하는 메소드
		/// </summary>
		/// <param name="entity">추가할 entity</param>
		public void Create(User entity)
		{
			_userManagementContext.Users.Add(entity);
			_userManagementContext.SaveChanges();
		}

		/// <summary>
		/// 테이블에서 id 값과 매핑되는 entity를 삭제하는 메소드
		/// </summary>
		/// <param name="id">삭제할 entitydml id 값</param>
		/// <exception cref="InvalidOperationException"></exception>
		public void Delete(long? id)
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

		/// <summary>
		/// 테이블의 모든 entity를 반환하는 메소드
		/// </summary>
		/// <returns></returns>
		public List<User> GetAll()
		{
			return _userManagementContext.Users.ToList();
		}

		/// <summary>
		/// 테이블에서 id 값을 가지고 하나의 entity를 반환하는 메소드
		/// </summary>
		/// <param name="id">가져올 entity의 id 값</param>
		/// <returns></returns>
		/// <exception cref="InvalidOperationException"></exception>
		public User GetOne(long? id)
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

		public User GetOneByLoginId(string loginId)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// 테이블 값을 변경하는 메소드
		/// </summary>
		/// <param name="entity">변경할 내용이 들어있는 entity</param>
		public void Update(User entity)
		{
			_userManagementContext.Users.Update(entity);
			_userManagementContext.SaveChanges();
		}
	}
}
