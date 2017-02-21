using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWarehouse_20170206.DbModels {
	public class InventoryReceiptAccumulatingFact {

		[Key , DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int LotNumber { get; set; }

		public int? ProductKey { get; set; }

		[ForeignKey("ProductKey")]
		public ProductDim Product { get; set; }

		public int? WarehouseKey { get; set; }

		[ForeignKey("WarehouseKey")]
		public WarehouseDim Warehouse { get; set; }

		public int? DateTruckArrivedKey { get; set; }

		public int? DateTruckDockedKet { get; set; }

		public int? TimeTruckDockedKey { get; set; }

		public int? DateTruckUnloadedKey { get; set; }

		public int? TimeTruckunloadedKey { get; set; }

		public int? TimeTruckUndockedKey { get; set; }

		public int? QuantityReceived { get; set; }

		public int? QuantityDamaged { get; set; }

		public int? QuantityReturned { get; set; }

		public int? QuantityReturnedStore { get; set; }
	}
}
