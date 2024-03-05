using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Models
{
	[Index(nameof(Admin.AdminId), IsUnique = true)]
	public class Admin
	{
		[Key]
		public long Id { get; set; }

		[Required]
		public string AdminId { get; set; }

		[Required]
		public string Password { get; set; }
	}
}
