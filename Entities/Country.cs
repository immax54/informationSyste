namespace informationSystemN.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Country")]
    public partial class Country
    {
        [Key]
        [Column(Order = 0)]
        public int CountryID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string CountryNameRu { get; set; }

        [Key]
        [Column(Order = 2)]
        public string CountryNameEng { get; set; }

        [Key]
        [Column(Order = 3)]
        public string CountryCode { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CountryCode2 { get; set; }
    }
}
