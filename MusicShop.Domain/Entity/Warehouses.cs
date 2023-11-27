using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
	public class Warehouses
	{
		[Key]
		public int ID_warehouses { get; set; }
		public string Warehouses_adress { get; set; }
		private int capacity;
		public int Capacity
		{
			set
			{
				if (value > 0 && value <= 1500)
				{
					capacity = value;
				}
				else
				{
					Console.WriteLine("[ERROR] Вместительность склада до 1500 музыкальных инструментов");
				}
			}
			get
			{
				return capacity;
			}
		}
		public Warehouses()
		{
		}
	}
}

