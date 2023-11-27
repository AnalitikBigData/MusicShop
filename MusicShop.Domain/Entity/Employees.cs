using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
	public class Employees
	{
		[Key]
		public int ID_employee { get; set; }
		[Required]
		public string Surname_employee { get; set; }
		public string Name_employee { get; set; }
		public string FatherName_employee { get; set; }
		public string Post_employee { get; set; }

	}
}

