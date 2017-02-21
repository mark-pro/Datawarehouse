namespace DataWarehouse_20170206.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CashierDim",
                c => new
                    {
                        CashierKey = c.Int(nullable: false, identity: true),
                        CashierEmployeeID = c.Int(),
                        CashierName = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.CashierKey);
            
            CreateTable(
                "dbo.DateDim",
                c => new
                    {
                        DateKey = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false, storeType: "date"),
                        Holiday = c.String(maxLength: 50),
                        Fiscalyear = c.Short(nullable: false),
                        FiscalPeriod = c.Short(nullable: false),
                        FiscalWeek = c.Short(nullable: false),
                        CalendarYear = c.String(maxLength: 10),
                        SalesFactKey = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DateKey);
            
            CreateTable(
                "dbo.SalesFact",
                c => new
                    {
                        SalesFactKey = c.Int(nullable: false, identity: true),
                        DateDimKey = c.Int(nullable: false),
                        ProductKey = c.Int(nullable: false),
                        StoreKey = c.Int(nullable: false),
                        CashierKey = c.Int(nullable: false),
                        PaymentMethodKey = c.Int(nullable: false),
                        SaleQuantity = c.Int(nullable: false),
                        RegularUnitPrice = c.Decimal(nullable: false, storeType: "money"),
                        DiscountUnitPrice = c.Decimal(nullable: false, storeType: "money"),
                        NetUnitPrice = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.SalesFactKey)
                .ForeignKey("dbo.CashierDim", t => t.CashierKey, cascadeDelete: true)
                .ForeignKey("dbo.DateDim", t => t.SalesFactKey)
                .ForeignKey("dbo.ProductDim", t => t.ProductKey, cascadeDelete: true)
                .ForeignKey("dbo.StoreDim", t => t.StoreKey, cascadeDelete: true)
                .Index(t => t.SalesFactKey)
                .Index(t => t.ProductKey)
                .Index(t => t.StoreKey)
                .Index(t => t.CashierKey);
            
            CreateTable(
                "dbo.ProductDim",
                c => new
                    {
                        ProductKey = c.Int(nullable: false, identity: true),
                        SKUNumber = c.Int(),
                        ProductDescription = c.String(),
                        BrandDescription = c.String(),
                        SubcategoryDescription = c.String(),
                        CategoryDescription = c.String(),
                        DepartmnetNumber = c.Int(),
                        DepartmentDescription = c.String(),
                        PackageTypeDescription = c.String(),
                        PackageSize = c.Int(),
                        FatContent = c.Int(),
                        DietType = c.String(),
                        Weight = c.Int(),
                        WeightUnitOfMeasure = c.String(),
                        StorageType = c.String(),
                        ShelfLifeType = c.String(),
                        ShelfWidth = c.Int(),
                        ShelfHeight = c.Int(),
                        ShelfDepth = c.Int(),
                    })
                .PrimaryKey(t => t.ProductKey);
            
            CreateTable(
                "dbo.StoreDim",
                c => new
                    {
                        StoreKey = c.Int(nullable: false, identity: true),
                        StoreName = c.String(maxLength: 50),
                        StoreCity = c.String(maxLength: 50),
                        StoreState = c.String(maxLength: 50),
                        StoreZip = c.Int(nullable: false),
                        StoreAddress = c.String(maxLength: 50),
                        StoreType = c.String(maxLength: 50),
                        SotreSqFt = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StoreKey);
            
            CreateTable(
                "dbo.InventoryReceiptAccumulatingFact",
                c => new
                    {
                        LotNumber = c.Int(nullable: false, identity: true),
                        ProductKey = c.Int(),
                        WarehouseKey = c.Int(),
                        DateTruckArrivedKey = c.Int(),
                        DateTruckDockedKet = c.Int(),
                        TimeTruckDockedKey = c.Int(),
                        DateTruckUnloadedKey = c.Int(),
                        TimeTruckunloadedKey = c.Int(),
                        TimeTruckUndockedKey = c.Int(),
                        QuantityReceived = c.Int(),
                        QuantityDamaged = c.Int(),
                        QuantityReturned = c.Int(),
                        QuantityReturnedStore = c.Int(),
                    })
                .PrimaryKey(t => t.LotNumber)
                .ForeignKey("dbo.ProductDim", t => t.ProductKey)
                .ForeignKey("dbo.WarehouseDim", t => t.WarehouseKey)
                .Index(t => t.ProductKey)
                .Index(t => t.WarehouseKey);
            
            CreateTable(
                "dbo.WarehouseDim",
                c => new
                    {
                        WarehouseKey = c.Int(nullable: false, identity: true),
                        WarehouseName = c.String(maxLength: 50),
                        totalSqFtSize = c.Int(),
                        RefridgeratedSqFtSize = c.Int(),
                        FrozenSqFtSize = c.Int(),
                        Address1 = c.String(maxLength: 50),
                        Address2 = c.String(maxLength: 50),
                        City = c.String(maxLength: 50),
                        State = c.String(maxLength: 50),
                        ZipCode = c.Int(),
                    })
                .PrimaryKey(t => t.WarehouseKey);
            
            CreateTable(
                "dbo.InventorySnapshotFact",
                c => new
                    {
                        InventoryID = c.Int(nullable: false, identity: true),
                        ProductKey = c.Int(),
                        StoreKey = c.Int(),
                        QuantityOnHand = c.Int(),
                        InventoryCost = c.Decimal(storeType: "money"),
                        QuantityDamaged = c.Int(),
                        InventoryValueRetailPrice = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => t.InventoryID)
                .ForeignKey("dbo.ProductDim", t => t.ProductKey)
                .ForeignKey("dbo.StoreDim", t => t.StoreKey)
                .Index(t => t.ProductKey)
                .Index(t => t.StoreKey);
            
            CreateTable(
                "dbo.TimeDim",
                c => new
                    {
                        TimeKey = c.Int(nullable: false, identity: true),
                        Hour = c.Byte(),
                        Minute = c.Byte(),
                        Second = c.Byte(),
                        HourName = c.String(maxLength: 50),
                        Time = c.Time(precision: 7),
                        Shift = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.TimeKey);
            
            CreateTable(
                "dbo.TransactionTypeDim",
                c => new
                    {
                        TransactionTypeKey = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TransactionTypeKey);
            
            CreateTable(
                "dbo.WarehouseInventoryTransactionFact",
                c => new
                    {
                        WarehouseInventoryID = c.Int(nullable: false, identity: true),
                        DateKey = c.Int(),
                        TimeKey = c.Int(),
                        ProductKey = c.Int(),
                        WarehouseKey = c.Int(),
                        TransactionTypeKey = c.Int(nullable: false),
                        SourceTransactionID = c.Int(),
                        PONumber = c.String(maxLength: 50),
                        LotNumber = c.String(maxLength: 50),
                        Quantity = c.Int(),
                        Cost = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.WarehouseInventoryID)
                .ForeignKey("dbo.DateDim", t => t.DateKey)
                .ForeignKey("dbo.ProductDim", t => t.ProductKey)
                .ForeignKey("dbo.TimeDim", t => t.TimeKey)
                .ForeignKey("dbo.TransactionTypeDim", t => t.TransactionTypeKey, cascadeDelete: true)
                .ForeignKey("dbo.WarehouseDim", t => t.WarehouseKey)
                .Index(t => t.DateKey)
                .Index(t => t.TimeKey)
                .Index(t => t.ProductKey)
                .Index(t => t.WarehouseKey)
                .Index(t => t.TransactionTypeKey);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WarehouseInventoryTransactionFact", "WarehouseKey", "dbo.WarehouseDim");
            DropForeignKey("dbo.WarehouseInventoryTransactionFact", "TransactionTypeKey", "dbo.TransactionTypeDim");
            DropForeignKey("dbo.WarehouseInventoryTransactionFact", "TimeKey", "dbo.TimeDim");
            DropForeignKey("dbo.WarehouseInventoryTransactionFact", "ProductKey", "dbo.ProductDim");
            DropForeignKey("dbo.WarehouseInventoryTransactionFact", "DateKey", "dbo.DateDim");
            DropForeignKey("dbo.InventorySnapshotFact", "StoreKey", "dbo.StoreDim");
            DropForeignKey("dbo.InventorySnapshotFact", "ProductKey", "dbo.ProductDim");
            DropForeignKey("dbo.InventoryReceiptAccumulatingFact", "WarehouseKey", "dbo.WarehouseDim");
            DropForeignKey("dbo.InventoryReceiptAccumulatingFact", "ProductKey", "dbo.ProductDim");
            DropForeignKey("dbo.SalesFact", "StoreKey", "dbo.StoreDim");
            DropForeignKey("dbo.SalesFact", "ProductKey", "dbo.ProductDim");
            DropForeignKey("dbo.SalesFact", "SalesFactKey", "dbo.DateDim");
            DropForeignKey("dbo.SalesFact", "CashierKey", "dbo.CashierDim");
            DropIndex("dbo.WarehouseInventoryTransactionFact", new[] { "TransactionTypeKey" });
            DropIndex("dbo.WarehouseInventoryTransactionFact", new[] { "WarehouseKey" });
            DropIndex("dbo.WarehouseInventoryTransactionFact", new[] { "ProductKey" });
            DropIndex("dbo.WarehouseInventoryTransactionFact", new[] { "TimeKey" });
            DropIndex("dbo.WarehouseInventoryTransactionFact", new[] { "DateKey" });
            DropIndex("dbo.InventorySnapshotFact", new[] { "StoreKey" });
            DropIndex("dbo.InventorySnapshotFact", new[] { "ProductKey" });
            DropIndex("dbo.InventoryReceiptAccumulatingFact", new[] { "WarehouseKey" });
            DropIndex("dbo.InventoryReceiptAccumulatingFact", new[] { "ProductKey" });
            DropIndex("dbo.SalesFact", new[] { "CashierKey" });
            DropIndex("dbo.SalesFact", new[] { "StoreKey" });
            DropIndex("dbo.SalesFact", new[] { "ProductKey" });
            DropIndex("dbo.SalesFact", new[] { "SalesFactKey" });
            DropTable("dbo.WarehouseInventoryTransactionFact");
            DropTable("dbo.TransactionTypeDim");
            DropTable("dbo.TimeDim");
            DropTable("dbo.InventorySnapshotFact");
            DropTable("dbo.WarehouseDim");
            DropTable("dbo.InventoryReceiptAccumulatingFact");
            DropTable("dbo.StoreDim");
            DropTable("dbo.ProductDim");
            DropTable("dbo.SalesFact");
            DropTable("dbo.DateDim");
            DropTable("dbo.CashierDim");
        }
    }
}
