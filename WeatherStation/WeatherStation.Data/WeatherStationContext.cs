namespace WeatherStation.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WeatherStationContext : DbContext
    {
        public WeatherStationContext()
            : base("name=WeatherStationContext")
        {
        }

        public virtual DbSet<inf_sensor_data> inf_sensor_data { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<inf_sensor_data>()
                .Property(e => e.value)
                .HasPrecision(9, 6);

            modelBuilder.Entity<inf_sensor_data>()
                .Property(e => e.latitude)
                .HasPrecision(9, 6);

            modelBuilder.Entity<inf_sensor_data>()
                .Property(e => e.longitude)
                .HasPrecision(9, 6);
        }
    }
}
