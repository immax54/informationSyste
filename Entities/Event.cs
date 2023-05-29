namespace informationSystemN.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Event")]
    public partial class Event
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EventID { get; set; }

        [Required]
        public string EventName { get; set; }

        [Required]
        public string EventDate { get; set; }

        public int EventDays { get; set; }

        public int EventCity { get; set; }

        public string EventPhoto { get; set; }

        [StringLength(100)]
        public string EventBranch { get; set; }
    }
}
