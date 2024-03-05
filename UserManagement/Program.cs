using Microsoft.Extensions.DependencyInjection;
using UserManagement.Forms;
using UserManagement.IServices;
using UserManagement.Models;
using UserManagement.Services;

namespace UserManagement
{
	public static class Program
	{
		public static bool isLogin = false;

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();

			// 서비스 컨테이너 생성
			var services = new ServiceCollection();

			// 데이터베이스와 상호작용 할 Context 등록
			services.AddDbContext<UserManagementContext>();

			// 싱글턴 패턴 적용
			services.AddSingleton<DashBoard>();

			// AddTransient 메소드를 사용해 필요할 때 객체 생성하고 반환
			services.AddTransient<IQuery<User>, UserService>();
			services.AddTransient<IQuery<Admin>, AdminService>();
			services.AddTransient<UserCreate>();
			services.AddTransient<UserUpdate>();
			services.AddTransient<Login>();
			services.AddTransient<Signup>();

			// 서비스 컨테이너에 등록된 서비스들을 생성하고 관리하는 ServiceProvider
			using ServiceProvider serviceProvider = services.BuildServiceProvider();

			// DashBoard 클래스 인스턴스 요청
			var dashBoard = serviceProvider.GetRequiredService<DashBoard>();
			var login = serviceProvider.GetRequiredService<Login>();

			Application.Run(login);

			if (isLogin == true)
			{
				Application.Run(dashBoard);
			}
		}
	}
}