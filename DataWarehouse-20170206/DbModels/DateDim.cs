using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWarehouse_20170206.DbModels {
	public class DateDim {

		[Key , DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int DateKey { get; set; }

		[Column(TypeName = "Date")]
		public DateTime Date { get; set; }

		[MaxLength(50)]
		public string Holiday { get; set; }

		public short Fiscalyear { get; set; }

		public short FiscalPeriod { get; set; }

		public short FiscalWeek { get; set; }

		[MaxLength(10)]
		public string CalendarYear { get; set; }

		public int SalesFactKey { get; set; }

		[ForeignKey("SalesFactKey")]
		public SalesFact SalesFact { get; set; }
	}
}
