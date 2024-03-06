using UserManagement.IServices;
using UserManagement.Models;

namespace UserManagement.Forms
{
	public partial class UserUpdate : Form
	{
		private readonly IQuery<User> _iQuery;
		private readonly UserManagementContext _userManagementContext;

		public UserUpdate(IQuery<User> iQuery, UserManagementContext userManagementContext)
		{
			InitializeComponent();
			_iQuery = iQuery;
			_userManagementContext = userManagementContext;
		}

		public User UserInfo { get; set; }

		/// <summary>
		/// Create 수행 후 Input 속성 값들을 모두 초기화
		/// </summary>
		public void InputClear()
		{
			tbPhone.Clear();
			tbUsername.Clear();
			rdbFemale.Checked = false;
			rdbMale.Checked = false;
			cbLesson.SelectedIndex = -1;
		}

		/// <summary>
		/// input 속성에 값이 비어있는지 체크
		/// </summary>
		/// <returns>비어있지 않다면 true 비어있다면 false 반환</returns>
		public bool InputCheck()
		{
			if (!string.IsNullOrWhiteSpace(tbUsername.Text) && !string.IsNullOrWhiteSpace(tbPhone.Text)
				&& !string.IsNullOrWhiteSpace(cbLesson.Text) && (rdbFemale.Checked || rdbMale.Checked))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 수정할 정보의 값들을 input에 뿌려주는 Load 메소드
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void UserUpdate_Load(object sender, EventArgs e)
		{
			tbUsername.Text = UserInfo.Username;
			tbPhone.Text = UserInfo.Phone;
			cbLesson.Text = UserInfo.Lesson;
			if (UserInfo.Gender.Equals("남성"))
			{
				rdbMale.Checked = true;
			}
			else
			{
				rdbFemale.Checked = true;
			}
		}

		/// <summary>
		/// 수정된 정보로 회원 정보를 수정해 db에 적용하는 버튼 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("회원 정보를 수정하시겠습니까?", "회원 정보 수정", MessageBoxButtons.OKCancel);

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
					if (phoneValid == null || phoneValid.Id == UserInfo.Id)
					{
						UserInfo.Username = tbUsername.Text;
						UserInfo.Phone = tbPhone.Text;
						UserInfo.Lesson = cbLesson.Text;
						UserInfo.Gender = gender;
						_iQuery.Update(UserInfo);

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
