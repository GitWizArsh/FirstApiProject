namespace FirstAPI_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EMPLOYEES")]
    public partial class EMPLOYEE
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string First_Name { get; set; }

        [Required]
        [StringLength(30)]
        public string Last_Name { get; set; }

        [StringLength(30)]
        public string email { get; set; }

        public int salary { get; set; }
    }
}
