namespace WeatherStation.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class inf_sensor_data
    {
        public int id { get; set; }

        [StringLength(100)]
        public string subject { get; set; }

        [StringLength(100)]
        public string unit_of_measure { get; set; }

        [Required]
        [StringLength(100)]
        public string measure_name { get; set; }

        public decimal value { get; set; }

        [Required]
        [StringLength(100)]
        public string guid { get; set; }

        public DateTime time_created { get; set; }

        public decimal? latitude { get; set; }

        public decimal? longitude { get; set; }
    }
}
