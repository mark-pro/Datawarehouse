namespace DataWarehouse_20170206 {
	using DbModels;
	using System;
	using System.Data.Entity;
	using System.Data.Entity.ModelConfiguration.Conventions;
	using System.Linq;

	public class GroceryStore : DbContext {
		// Your context has been configured to use a 'GroceryStore' connection string from your application's 
		// configuration file (App.config or Web.config). By default, this connection string targets the 
		// 'DataWarehouse_20170206.GroceryStore' database on your LocalDb instance. 
		// 
		// If you wish to target a different database and/or database provider, modify the 'GroceryStore' 
		// connection string in the application configuration file.
		public GroceryStore()
			: base("name=GroceryStore") {
		}


		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			base.OnModelCreating(modelBuilder);
		}

		// Add a DbSet for each entity type that you want to include in your model. For more information 
		// on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

		// public virtual DbSet<MyEntity> MyEntities { get; set; }
		public virtual DbSet<CashierDim> CashierDim { get; set; }
		public virtual DbSet<DateDim> DateDim { get; set; }
		public virtual DbSet<InventoryReceiptAccumulatingFact> InventoryReceiptAccumulatingFact { get; set; }
		public virtual DbSet<InventorySnapshotFact> InventorySnapshotFact { get; set; }
		public virtual DbSet<SalesFact> SalesFact { get; set; }
		public virtual DbSet<StoreDim> StoreDim { get; set; }
		public virtual DbSet<TimeDim> TimeDim { get; set; }
		public virtual DbSet<TransactionTypeDim> TransactionTypeDim { get; set; }
		public virtual DbSet<ProductDim> ProductDim { get; set; }
		public virtual DbSet<WarehouseDim> WarehouseDim { get; set; }
		public virtual DbSet<WarehouseInventoryTransactionFact> WarehouseInventoryTransactionFact { get; set; }
		public virtual DbSet<GeneralLedgerMonthlySnapshot> GeneralLedgerMonthlySnapshot { get; set; }
	}

	//public class MyEntity
	//{
	//    public int Id { get; set; }
	//    public string Name { get; set; }
	//}
}