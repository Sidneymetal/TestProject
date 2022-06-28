using Microsoft.EntityFrameworkCore;
using TestAikoProject.Lib.Models;

namespace TestAikoProject.Lib.Date.Repository
{
    public class TestAikoContext : DbContext
    {
        public TestAikoContext(DbContextOptions context) : base(context)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("operation");

            modelBuilder.Entity<Equipment>().ToTable("equipment");
            modelBuilder.Entity<Equipment>().HasKey(x => x.Id);
            modelBuilder.Entity<Equipment>().HasMany(x => x.ListEquipmentPositionHistory).WithOne(x => x.Equipment).HasForeignKey(x => x.EquipmentId);
            modelBuilder.Entity<Equipment>().HasMany(x => x.ListEquipmentStateHistory).WithOne(x => x.Equipment).HasForeignKey(x => x.EquipmentId);

            modelBuilder.Entity<EquipmentModel>().ToTable("equipment_model");
            modelBuilder.Entity<EquipmentModel>().HasKey(x => x.Id);
            modelBuilder.Entity<EquipmentModel>().HasMany(x => x.ListEquipmentModelStateHourlyEarnings).WithOne(x => x.EquipmentModel).HasForeignKey(x => x.EquipmentModelId);
        
            
            modelBuilder.Entity<EquipmentState>().ToTable("equipment_state");
            modelBuilder.Entity<EquipmentState>().HasKey(x => x.Id);
            modelBuilder.Entity<EquipmentState>().HasMany(x => x.ListEquipmentModelStateHourlyEarnings).WithOne(x => x.EquipmentState).HasForeignKey(x => x.EquipmentStateId);


            modelBuilder.Entity<EquipmentStateHistory>().ToTable("equipment_state_history");
            modelBuilder.Entity<EquipmentStateHistory>().HasKey(x => new { x.EquipmentId, x.Date });
            modelBuilder.Entity<EquipmentStateHistory>().Ignore(x => x.Id);

            modelBuilder.Entity<EquipmentModelStateHourlyEarnings>().ToTable("equipment_model_state_hourly_earnings");
            modelBuilder.Entity<EquipmentModelStateHourlyEarnings>().HasKey(x => new { x.EquipmentModelId, x.EquipmentStateId});
            modelBuilder.Entity<EquipmentModelStateHourlyEarnings>().Ignore(x => x.Id);

            modelBuilder.Entity<EquipmentPositionHistory>().ToTable("equipment_position_history");
            modelBuilder.Entity<EquipmentPositionHistory>().HasKey(x => new { x.EquipmentId, x.Date });
            modelBuilder.Entity<EquipmentPositionHistory>().Ignore(x => x.Id);



        }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentModel> EquipmentsModels { get; set; }
        public DbSet<EquipmentModelStateHourlyEarnings> EquipmentsModelsStateHoyrlyEarnings { get; set; }
        public DbSet<EquipmentPositionHistory> EquipmentsPositionHistory { get; set; }
        public DbSet<EquipmentState> EquipmentsState { get; set; }
        public DbSet<EquipmentStateHistory> EquipmentsStateHistory { get; set; }
    }
}