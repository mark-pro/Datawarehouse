using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataWarehouse_20170206.DbModels {
	public class TimeDim {

		[Key , DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int TimeKey { get; set; }

		public byte? Hour { get; set; }

		public byte? Minute { get; set; }

		public byte? Second { get; set; }

		[MaxLength(50)]
		public string HourName { get; set; }

		[Column(TypeName = "Time")]
		public TimeSpan? Time { get; set; }

		[MaxLength(50)]
		public string Shift { get; set; }
	}
}