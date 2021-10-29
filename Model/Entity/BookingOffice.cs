using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Entity
{
    public class BookingOffice
    {
        [Required]
        public int Id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        [Required]
        public string OfficeName { get; set; }

        [Column(TypeName = "varchar(10)")]
        [Required]
        public string Phone { get; set; }

        [Required]
        public int TripId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string Place { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public DateTime ContractStart { get; set; }

        [Required]
        public DateTime ContractEnd { get; set; }

        public virtual Trip Trip { get; set; }
    }
}
