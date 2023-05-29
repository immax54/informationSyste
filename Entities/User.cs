namespace informationSystemN.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [Required]
        public string UserPassword { get; set; }

        public int UserRole { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string UserSurname { get; set; }

        [Required]
        public string UserPatronymic { get; set; }

        [Required]
        public string UserPhoto { get; set; }

        [Required]
        [StringLength(100)]
        public string UserEmail { get; set; }

        [Required]
        public string UserCountry { get; set; }

        [Required]
        public string UserPhone { get; set; }

        [Required]
        [StringLength(100)]
        public string UserGender { get; set; }

        public string UserNaprav { get; set; }

        public string UserEvent { get; set; }

        [Required]
        public string UserBirthday { get; set; }

        public int UserID { get; set; }

        public virtual Role Role { get; set; }
    }
}
