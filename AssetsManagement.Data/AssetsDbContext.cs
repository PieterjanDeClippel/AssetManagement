using Microsoft.EntityFrameworkCore;
using AssetManagment.Data.Entities;

namespace AssetManagment.Data
{
    public class AssetsContext : DbContext
    {
        public AssetsContext(DbContextOptions<AssetsContext> options) : base(options)
        {
        }

        public virtual DbSet<Contact> Contacts { get; set; }

        public virtual DbSet<DeviceAssignment> DeviceAssignments { get; set; }

        public virtual DbSet<DeviceCategory> DeviceCategories { get; set; }

        public virtual DbSet<DeviceLocation> DeviceLocations { get; set; }

        public virtual DbSet<Device> Devices { get; set; }

    }
}
