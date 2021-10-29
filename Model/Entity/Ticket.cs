using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Entity
{
    public class Ticket
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string CustomerName { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        [ForeignKey("Car")]
        public string LicensePlate { get; set; }

        [Required]
        public int TripId { get; set; }

        public virtual Trip Trip { get; set; }
        public virtual Car Car { get; set; }
    }
}
