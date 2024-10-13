using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTDK_CanHo_DaoCongTri.Models
{
    public class AppDB : DbContext
    {
        public AppDB() : base(new SqlConnection()
        {
            //ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\db.mdf;Integrated Security=True;Connect Timeout=30"
            ConnectionString = $"Data Source=DESKTOP-79L3NVT;Initial Catalog=Apartment;Integrated Security=True"
        }, true)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Models.Type> Types { get; set; }
        public virtual DbSet<Models.Apartment> Apartments { get; set; }
        public virtual DbSet<Models.Employee> Employees { get; set; }
        public virtual DbSet<Models.MaintenanceRequest> MaintenanceRequests { get; set; }
    }
}
