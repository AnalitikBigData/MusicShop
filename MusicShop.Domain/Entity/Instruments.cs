using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Date;
namespace Domain.Entity
{
	public class Instruments
	{
		[Key]
		public int ID_instrument { get; set; }
		[Required]
		public string Name_instrument { get; set; }
        public int Year_of_realize { get; set; }
		public string Materials { get; set; }
		[Display(Name = "Factories")]
		public virtual int FactoriesID_factory { get; set; }
		[ForeignKey("FactoriesID_factory")]
		public virtual Factories Factories { get; set; }
		[Display(Name = "Warehouses")]
		public virtual int WarehousesID_warehouses { get; set; }
		[ForeignKey("WarehousesID_warehouses")]
		public virtual Warehouses Warehouses { get; set; }
		public DateTime Date_of_arrival { get; set; }
		private float price_of_arrival;
		public float Price_of_arrival
		{
			set
			{
				if (value > 0)
				{
					price_of_arrival = value;
				}
				else
				{
					Console.WriteLine("[ERROR] Цена прихода не может быть отрицательной");
				}
			}
			get
			{
				return price_of_arrival;
			}
		}
		public string Instruction { get; set; }
		public string Instrument_state { get; set; }
		private float sale_price;
		public float Sale_price
		{
			set
			{
				if (value > 0)
				{
					sale_price = value;
				}
				else
				{
                    Console.WriteLine("[ERROR] Цена продажи не может быть отрицательной");
                }
			}
			get
			{
				return sale_price;
			}
		}

		public string Warrantly_card { get; set; }

        public Instruments()
		{
		}
	}
}

