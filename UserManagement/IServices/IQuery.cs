using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.IServices
{
	public interface IQuery<T>
	{
		// 전체 데이터 조회
		List<T> GetAll();

		// 특정 데이터 조회
		T GetOne(int id);

		// 데이터 추가
		void Create(T entity);

		// 데이터 수정
		void Update(T entity);

		// 데이터 삭제
		void Delete(int id);
	}
}
