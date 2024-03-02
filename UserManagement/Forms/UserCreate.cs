using UserManagement.IServices;
using UserManagement.Models;

namespace UserManagement.Forms
{
	public partial class UserCreate : Form
	{
		private readonly IQuery<User> _iQuery;
		private readonly UserManagementContext _userManagementContext;

		public UserCreate(IQuery<User> iQuery, UserManagementContext userManagementContext)
		{
			InitializeComponent();
			_iQuery = iQuery;
			_userManagementContext = userManagementContext;
		}

		/// <summary>
		/// Create 수행 후 Input 속성 값들을 모두 초기화
		/// </summary>
		public void InputClear()
		{
			tbPhone.Clear();
			tbUsername.Clear();
			rdbFemale.Checked = false;
			rdbMale.Checked = false;
			cbLesson.Text = "";
		}

		/// <summary>
		/// input 속성들에 값이 비어있는지 체크하는 메소드
		/// </summary>
		/// <returns>비어있지 않다면 true, 비어있다면 false 리턴</returns>
		public bool InputCheck()
		{
			if (tbPhone.Text != null && tbUsername.Text != null && cbLesson.Text != null && (rdbFemale.Checked || rdbMale.Checked))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 입력된 정보로 회원 등록하는 버튼 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCreate_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("회원을 등록하시겠습니까?", "회원 등록", MessageBoxButtons.OKCancel);

			if (result == DialogResult.OK)
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

				var phoneValid = _userManagementContext.Users.FirstOrDefault(x => x.Phone == tbPhone.Text);

				if (InputCheck())
				{
					if (phoneValid == null)
					{
						User user = new User()
						{
							Username = tbUsername.Text,
							Phone = tbPhone.Text,
							Lesson = cbLesson.Text,
							Gender = gender
						};

						_iQuery.Create(user);

						InputClear();

						Close();
					}
					else
					{
						MessageBox.Show("중복된 전화번호입니다.");
					}
				}
				else
				{
					MessageBox.Show("모든 항목을 입력해 주세요.");
				}
			}
		}
	}
}
