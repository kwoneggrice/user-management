using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace UserManagement.Models
{
	[Index(nameof(User.Phone), IsUnique = true)]
	public class User
	{
		[Key]
		public long Id { get; set; }

		[Required]
		public string Username { get; set; }

		[Required]
		public string Phone { get; set; }

		[Required]
		public string Lesson { get; set; }

		[Required]
		public string Gender { get; set; }
	}
}
