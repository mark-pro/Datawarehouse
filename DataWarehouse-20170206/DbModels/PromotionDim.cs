using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWarehouse_20170206.DbModels {
	public class PromotionDim {

		[Key , DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int PromotionKey { get; set; }

		[MaxLength(25)]
		public string Name { get; set; }

		[MaxLength(150)]
		public string Description { get; set; }

		[Column(TypeName = "Money")]
		public decimal Discount { get; set; }

		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}
}
