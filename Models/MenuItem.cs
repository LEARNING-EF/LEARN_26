namespace Models
{
	public class MenuItem : BaseEntity
	{
		#region Configuration
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MenuItem>
		{
			public Configuration() : base()
			{
				HasOptional(current => current.Parent)
					.WithMany(menuItem => menuItem.Children)
					.HasForeignKey(current => current.ParentId)
					.WillCascadeOnDelete(false);
			}
		}
		#endregion /Configuration

		public MenuItem() : base()
		{
		}

		// **********
		// **********
		// **********
		public MenuItem Parent { get; set; }
		// **********

		// **********
		public System.Guid? ParentId { get; set; }
		// **********
		// **********
		// **********

		// **********
		public int Code { get; set; }
		// **********

		// **********
		public string Name { get; set; }
		// **********

		// **********
		public virtual System.Collections.Generic.IList<MenuItem> Children { get; set; }
		// **********
	}
}
