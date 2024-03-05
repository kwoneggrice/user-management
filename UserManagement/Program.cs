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

			// ���� �����̳� ����
			var services = new ServiceCollection();

			// �����ͺ��̽��� ��ȣ�ۿ� �� Context ���
			services.AddDbContext<UserManagementContext>();

			// �̱��� ���� ����
			services.AddSingleton<DashBoard>();

			// AddTransient �޼ҵ带 ����� �ʿ��� �� ��ü �����ϰ� ��ȯ
			services.AddTransient<IQuery<User>, UserService>();
			services.AddTransient<IQuery<Admin>, AdminService>();
			services.AddTransient<UserCreate>();
			services.AddTransient<UserUpdate>();
			services.AddTransient<Login>();
			services.AddTransient<Signup>();

			// ���� �����̳ʿ� ��ϵ� ���񽺵��� �����ϰ� �����ϴ� ServiceProvider
			using ServiceProvider serviceProvider = services.BuildServiceProvider();

			// DashBoard Ŭ���� �ν��Ͻ� ��û
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