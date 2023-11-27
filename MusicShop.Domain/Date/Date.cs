using System;
namespace Domain.Date
{
	public class Date
	{
		public int Year { get; set; }
		private int month;
		public int Month
		{
			set
			{
				if (value <= 0 || value > 12)
				{
					Console.WriteLine("[ERROR] Не уложились в о временные рамки нашей Земли. Январь - ... - Декабрь состовляет от 1 до 12 месяцев.");
				}
				else
				{
					month = value;
				}
			}

			get
			{
				return month;
			}

		}
		private int day;
		public int Day
		{
			set
			{
				if (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)
				{
					if (value >= 1 && value <= 31)
					{
						day = value;
					}
					else
					{
						Console.WriteLine("[ERROR] Вы не вписались во временные рамки. В этом месяце максимум 31 день");
					}
				}
				if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
				{
                    if (value >= 1 && value <= 30)
                    {
                        day = value;
                    }
                    else
                    {
                        Console.WriteLine("[ERROR] Вы не вписались во временные рамки. В этом месяце максимум 30 дней");
                    }
                }
				if (Month == 2)
				{
					if (value >= 1 && value <= 29)
					{
						day = value;
					}
                    else
                    {
                        Console.WriteLine("[ERROR] Вы не вписались во временные рамки. В этом месяце максимум 28 или 29 дней");
                    }
                }
			}
		}
		public Date()
		{
		}
	}
}

