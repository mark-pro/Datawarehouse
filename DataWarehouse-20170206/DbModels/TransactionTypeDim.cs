using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataWarehouse_20170206.DbModels {
	public class TransactionTypeDim {

		[Key , DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int TransactionTypeKey { get; set; }

	}
}