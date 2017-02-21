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
	}
}
