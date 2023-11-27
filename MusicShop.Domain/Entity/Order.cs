using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
	public class Order
	{
		[Key]
		public int ID_order { get; set; }
		[Display (Name = "Customers")]
		public virtual int CustomersID_customer { get; set; }
		[ForeignKey("CustomersID_customer")]
		public virtual Customers Customers { get; set; }
		private float total_amount;
		public float  Total_amount
		{
			set
			{
				if(value > 0)
				{
					total_amount = value;
				}
				else
				{
					Console.WriteLine("[ERROR] итоговая цена заказа не может быть меньше или равно 0");
				}
			}
			get
			{
				return total_amount;
			}
		}
		public Order()
		{
		}
	}
}

