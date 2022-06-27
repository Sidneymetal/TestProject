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
            modelBuilder.Entity<Equipment>().ToTable("operation.equipment");
            modelBuilder.Entity<Equipment>().HasKey(x => x.Id);
            modelBuilder.Entity<Equipment>().HasMany(x => x.ListEquipmentPositionHistory).WithOne(x => x.Equipment).HasForeignKey(x => x.EquipmentId);

            modelBuilder.Entity<EquipmentModel>().ToTable("operation.equipment_model");
            modelBuilder.Entity<EquipmentModel>().HasKey(x => x.Id);
            modelBuilder.Entity<EquipmentModel>().HasMany(x => x.ListEquipmentModelStateHourlyEarnings).WithOne(x => x.EquipmentModel).HasForeignKey(x => x.EquipmentModelId);
            modelBuilder.Entity<EquipmentModel>().HasMany(x => x.ListEquipmentModelStateHourlyEarnings).WithOne(x => x.EquipmentModel).HasForeignKey(x => x.EquipmentStatetId);
            
            modelBuilder.Entity<EquipmentState>().ToTable("operation.equipment_state");
            modelBuilder.Entity<EquipmentState>().HasKey(x => x.Id);
            modelBuilder.Entity<EquipmentState>().HasMany(x => x.ListEquipmentModelStateHourlyEarnings).WithOne(x => x.EquipmentState).HasForeignKey(x => x.EquipmentState);


            modelBuilder.Entity<EquipmentStateHistory>().ToTable("operation.equipment_state_history");
            
            modelBuilder.Entity<EquipmentModelStateHourlyEarnings>().ToTable("operation.equipment_model_state_hourly_earnings");

            modelBuilder.Entity<EquipmentPositionHistory>().ToTable("operation.equipment_position_history");
        }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentModel> EquipmentsModels { get; set; }
        public DbSet<EquipmentModelStateHourlyEarnings> EquipmentsModelsStateHoyrlyEarnings { get; set; }
        public DbSet<EquipmentPositionHistory> EquipmentsPositionHistory { get; set; }
        public DbSet<EquipmentState> EquipmentsState { get; set; }
        public DbSet<EquipmentStateHistory> EquipmentsStateHistory { get; set; }
    }
}