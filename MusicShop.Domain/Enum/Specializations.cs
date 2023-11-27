using System;
using System.ComponentModel.DataAnnotations;
namespace Domain.Enum
{
	public enum Specializations
    {
		[Display(Name = "Производство ударных инструментов")]
		Percussion = 1,
		[Display(Name = "Производство духовых инструментов")]
		Brass = 2,
		[Display(Name = "Производство струнных инструментов")]
		String = 3,
		[Display(Name = "Производство клавишных инструментов")]
		Keyboard = 4
	}
}

