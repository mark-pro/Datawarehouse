using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWarehouse_20170206.DbModels {
	public class InventorySnapshotFact {

		[Key , DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int? InventoryID { get; set; }

		public int? ProductKey { get; set; }

		[ForeignKey("ProductKey")]
		public ProductDim Product { get; set; }

		public int? StoreKey { get; set; }

		[ForeignKey("StoreKey")]
		public StoreDim Store { get; set; }

		public int? QuantityOnHand { get; set; }

		[Column(TypeName = "Money")]
		public decimal? InventoryCost { get; set; }

		public int? QuantityDamaged { get; set; }

		[Column(TypeName = "Money")]
		public decimal? InventoryValueRetailPrice { get; set; }
	}
}
