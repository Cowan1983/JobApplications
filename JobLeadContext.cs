namespace JobApplication
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class JobLeadContext : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'JobApplication.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public JobLeadContext()
            : base("name=JobLeadContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<JobLeadContext, JobApplication.Migrations.Configuration>("JobLeadContext"));
        }
        
        public DbSet<Broker> Brokers { get; set; }
        public DbSet<JobLead> JobLeads {get; set;}
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Name> Names { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Note> Notes { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Broker>()
                .HasMany(p => p.Brokers)
                .WithMany()
                .Map(m =>
                {
                    m.MapLeftKey("BrokerID");
                    m.MapRightKey("AssociatedBrokerID");
                    m.ToTable("BrokerAssociation");
                });
           
        }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}