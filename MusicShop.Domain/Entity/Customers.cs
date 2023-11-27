using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
	public class Customers
	{
		[Key]
		public int ID_customer { get; set; }
		[Required]
		public string Name_customer { get; set; }
		public int Number_customer { get; set; }
		public string Mail_customer { get; set; }
		
	}
}

