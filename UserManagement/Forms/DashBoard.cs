using System.Data;
using UserManagement.IServices;
using UserManagement.Models;

namespace UserManagement.Forms
{
	public partial class DashBoard : Form
	{
		private readonly IQuery<User> _iQuery;
		private readonly UserCreate _userCreate;
		private readonly UserUpdate _userUpdate;
		private readonly UserManagementContext _userManagemaentContext;

		public DashBoard(IQuery<User> iQuery, UserCreate userCreate, UserUpdate userUpdate, UserManagementContext userManagementContext)
		{
			InitializeComponent();
			_iQuery = iQuery;
			_userCreate = userCreate;
			_userUpdate = userUpdate;
			_userManagemaentContext = userManagementContext;
			ShowPieChartGender();
			ShowPieChartLesson();
		}

		/// <summary>
		/// 전체 데이터 가져와 dgv에 뿌려주는 메소드
		/// </summary>
		public void RefreshDataTable()
		{
			var datas = _iQuery.GetAll();
			dgvDataTable.DataSource = datas;
		}

		/// <summary>
		/// dgv에서 선택한 행의 id값을 가져오는 메소드
		/// </summary>
		/// <returns>선택한 행의 id 값</returns>
		public long? GetEntityId()
		{
			if (dgvDataTable.SelectedRows.Count == 0)
			{
				MessageBox.Show("회원을 선택해 주세요.");
				return null;
			}
			else
			{
				long? targetId = Convert.ToInt64(dgvDataTable.SelectedRows[0].Cells["id"].Value.ToString());

				return targetId;
			}
		}

		/// <summary>
		/// 성별 원형 차트 그려주는 메소드
		/// </summary>
		private void ShowPieChartGender()
		{
			var datas = _userManagemaentContext.Users
				.GroupBy(x => x.Gender)
				.Select(g => new
				{
					Gender = g.Key,
					Count = g.Count()
				})
				.ToList();

			pieChartGender.Series.Clear();
			pieChartGender.Series.Add("남여 비율");
			pieChartGender.Series["남여 비율"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

			int totalUsers = datas.Sum(x => x.Count);

			foreach (var genderCount in datas)
			{
				double percentage = (genderCount.Count / (double)totalUsers) * 100;
				pieChartGender.Series["남여 비율"].Points.AddXY(genderCount.Gender, percentage);
			}
		}

		/// <summary>
		/// 강의 원형 차트 그려주는 메소드
		/// </summary>
		private void ShowPieChartLesson()
		{
			var datas = _userManagemaentContext.Users
				.GroupBy(x => x.Lesson)
				.Select(g => new
				{
					Lesson = g.Key,
					Count = g.Count()
				})
				.ToList();

			pieChartLesson.Series.Clear();
			pieChartLesson.Series.Add("강의별 비율");
			pieChartLesson.Series["강의별 비율"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

			int totalUsers = datas.Sum(x => x.Count);

			foreach (var lessonCount in datas)
			{
				double percentage = (lessonCount.Count / (double)totalUsers) * 100;
				pieChartLesson.Series["강의별 비율"].Points.AddXY(lessonCount.Lesson, percentage);
			}
		}

		/// <summary>
		/// 전체 테이블 조회해 dgv에 뿌려주는 버튼 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSearch_Click(object sender, EventArgs e)
		{
			RefreshDataTable();
		}

		/// <summary>
		/// 새로운 회원 등록하기 위한 버튼 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCreate_Click(object sender, EventArgs e)
		{
			_userCreate.ShowDialog();
		}

		/// <summary>
		/// 선택한 회원 정보를 삭제하기 위한 버튼 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDelete_Click(object sender, EventArgs e)
		{
			long? targetId = GetEntityId();

			if (targetId != null)
			{
				_iQuery.Delete(targetId);
				RefreshDataTable();
			}
		}

		/// <summary>
		/// 새로운 회원을 등록하기 위한 버튼 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			long? targetId = GetEntityId();

			if (targetId != null)
			{
				var data = _iQuery.GetOne(targetId);

				_userUpdate.UserInfo = data;

				_userUpdate.ShowDialog();
			}
		}

		/// <summary>
		/// 성별 원형차트 새롭게 갱신하는 메소드
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnGenderRefresh_Click(object sender, EventArgs e)
		{
			ShowPieChartGender();
		}

		/// <summary>
		/// 레슨 원형차트 새롭게 갱신하는 메소드
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnLessonRefresh_Click(object sender, EventArgs e)
		{
			ShowPieChartLesson();
		}
	}
}
