using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
	public class Services
	{
		[Key]
		public int ID_service { get; set; }
		[Required]
		public string Type_service { get; set; }
		public string Service_state { get; set; }
		public DateTime date_of_aplication { get; set; }
		public DateTime date_of_comletion { get; set; }
		private float service_price;
		public float Service_price
		{
			set
			{
				if (value > 0)
				{
					service_price = value;
				}
				else
				{
					Console.WriteLine("[ERROR] Цена услуги не может быть меньше 0");
				}
			}
			get
			{
				return service_price;
			}
		}

        public Services()
		{
		}
	}
}

