using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWarehouse_20170206.DbModels {
	public class SalesFact {

		[Key , DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int SalesFactKey { get; set; }

		public int DateDimKey { get; set; }

		[Required , ForeignKey("DateDimKey")]
		public DateDim DateDim { get; set; }

		public int ProductKey { get; set; }

		[Required , ForeignKey("ProductKey")]
		public ProductDim Product { get; set; }

		public int StoreKey { get; set; }

		[Required , ForeignKey("StoreKey")]
		public StoreDim Store { get; set; }

		public int CashierKey { get; set; }

		[Required , ForeignKey("CashierKey")]
		public CashierDim Cashier { get; set; }

		public int PaymentMethodKey { get; set; }

		public int SaleQuantity { get; set; }

		[Column(TypeName = "Money")]
		public decimal RegularUnitPrice { get; set; }


		[Column(TypeName = "Money")]
		public decimal DiscountUnitPrice { get; set; }

		[Column(TypeName = "Money")]
		public decimal NetUnitPrice { get; set; }
	}
}
