using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWarehouse_20170206.DbModels {
	public class GeneralLedgerMonthlySnapshot {

		[Key , DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int GeneralLedgerID { get; set; }
		public int AccountimngPeriodKey { get; set; }
		public int AccountKey { get; set; }
		public int LedgerKey { get; set; }
		public int OrganizationKey { get; set; }

		[Column(TypeName = "Money")]
		public decimal ChangeAmount { get; set; }

		[Column(TypeName = "Money")]
		public decimal CreditAmount { get; set; }

		[Column(TypeName = "Money")]
		public decimal DebitAmount { get; set; }

		[Column(TypeName = "Money")]
		public decimal NetChangeAmoutn { get; set; }
	}
}
