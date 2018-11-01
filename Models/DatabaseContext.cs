namespace Models
{
	public class DatabaseContext : System.Data.Entity.DbContext
	{
		static DatabaseContext()
		{
			System.Data.Entity.Database.SetInitializer
				(new System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>());
		}

		public DatabaseContext() : base()
		{
		}

		// **********
		public System.Data.Entity.DbSet<MenuItem> MenuItems { get; set; }
		// **********

		// **********
		public System.Data.Entity.DbSet<AccountCode> AccountCodes { get; set; }
		// **********

		protected override void OnModelCreating
			(System.Data.Entity.DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Configurations.Add(new MenuItem.Configuration());
			modelBuilder.Configurations.Add(new AccountCode.Configuration());
		}
	}
}
