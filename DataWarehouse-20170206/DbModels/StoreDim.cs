using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWarehouse_20170206.DbModels {
	public class StoreDim {
		
		[Key , DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int StoreKey { get; set; }

		[MaxLength(50)]
		public string StoreName { get; set; }

		[MaxLength(50)]
		public string StoreCity { get; set; }

		[MaxLength(50)]
		public string StoreState { get; set; }

		public int StoreZip { get; set; }

		[MaxLength(50)]
		public string StoreAddress { get; set; }

		[MaxLength(50)]
		public string StoreType { get; set; }

		public int SotreSqFt { get; set; }
	}
}
