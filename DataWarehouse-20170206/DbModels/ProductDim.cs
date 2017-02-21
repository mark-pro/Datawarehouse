using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataWarehouse_20170206.DbModels {
	public class ProductDim {

		[Key , DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int? ProductKey { get; set; }

		public int? SKUNumber { get; set; }

		public string ProductDescription { get; set; }

		public string BrandDescription { get; set; }

		public string SubcategoryDescription { get; set; }

		public string CategoryDescription { get; set; }

		public int? DepartmnetNumber { get; set; }

		public string DepartmentDescription { get; set; }

		public string PackageTypeDescription { get; set; }

		public int? PackageSize { get; set; }

		public int? FatContent { get; set; }

		public string DietType { get; set; }

		public int? Weight { get; set; }

		public string WeightUnitOfMeasure { get; set; }

		public string StorageType { get; set; }

		public string ShelfLifeType { get; set; }

		public int? ShelfWidth { get; set; }

		public int? ShelfHeight { get; set; }

		public int? ShelfDepth { get; set; }
	}
}