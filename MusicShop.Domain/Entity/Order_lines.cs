using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
	[Keyless]
	public class Order_lines
	{
		[Display(Name = "Instruments")]
		public virtual int InstrumentsID_instrument { get; set; }
		[ForeignKey("InstrumentsId_instrument")]
		public virtual Instruments Instruments { get; set; }
		[Display(Name = "Employees")]
		public virtual int EmployeesID_employee { get; set; }
		[ForeignKey("EmployeesId_employee")]
		public virtual Employees Employees { get; set; }
		[Display(Name = "Services")]
		public virtual int ServicesID_service { get; set; }
		[ForeignKey("ServicesID_service")]
		public virtual Services Services { get; set; }
		[Display(Name = "Order")]
		public virtual int OrdersID_order { get; set; }
		[ForeignKey("OrdersID_order")]
		public virtual Order Order { get; set; }
		private float price_with_discount;
		public float Price_with_discount
		{
			set
			{
				if (value > 0)
				{
					price_with_discount = value;
				}
				else
				{
					Console.WriteLine("[ERROR] Текущая цена в заказе без скидки не может быть меньше 0");
				}
			}
			get
			{
				return price_with_discount;
			}
		}
        private float discount_price;
        public float Discount_price
        {
            set
            {
                if (value > 0)
                {
                    discount_price = value;
                }
                else
                {
                    Console.WriteLine("[ERROR] Текущая цена в заказе со скидкой не может быть меньше 0");
                }
            }
            get
            {
                return discount_price;
            }
        }
        public Order_lines()
		{
		}
	}
}

