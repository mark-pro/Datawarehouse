using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWarehouse_20170206.DbModels {
	public class WarehouseInventoryTransactionFact {

		[Key , DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int? WarehouseInventoryID { get; set; }

		public int? DateKey { get; set; }

		[ForeignKey("DateKey")]
		public DateDim Date { get; set; }

		public int? TimeKey { get; set; }

		[ForeignKey("TimeKey")]
		public TimeDim Time { get; set; }

		public int? ProductKey { get; set; }

		[ForeignKey("ProductKey")]
		public ProductDim Product { get; set; }

		public int? WarehouseKey { get; set; }

		[ForeignKey("WarehouseKey")]
		public WarehouseDim Warehouse { get; set; }

		public int TransactionTypeKey { get; set; }

		[ForeignKey("TransactionTypeKey")]
		public TransactionTypeDim TransactionType { get; set; }

		public int? SourceTransactionID { get; set; }

		[MaxLength(50)]
		public string PONumber { get; set; }

		[MaxLength(50)]
		public string LotNumber { get; set; }

		public int? Quantity  { get; set; }

		[Column(TypeName = "Money")]
		public decimal Cost { get; set; }
	}
}
