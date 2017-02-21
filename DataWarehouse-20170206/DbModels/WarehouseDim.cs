using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataWarehouse_20170206.DbModels {
	public class WarehouseDim {

		[Key , DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int? WarehouseKey { get; set; }

		[MaxLength(50)]
		public string WarehouseName { get; set; }

		public int? totalSqFtSize { get; set; }

		public int? RefridgeratedSqFtSize { get; set; }

		public int? FrozenSqFtSize { get; set; }

		[MaxLength(50)]
		public string Address1 { get; set; }

		[MaxLength(50)]
		public string Address2 { get; set; }

		[MaxLength(50)]
		public string City { get; set; }

		[MaxLength(50)]
		public string State { get; set; }

		public int? ZipCode { get; set; }
	}
}