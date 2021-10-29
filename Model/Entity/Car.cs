using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entity
{
    public class Car
    {
        [Required]
        [Key]
        [Column(TypeName = "varchar(20)")]
        public string LicensePlate { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Type { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Color { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Company { get; set; }  

        [Required]
        public int ParkingLotId { get; set; }

        public virtual ParkingLot ParkingLot { get; set; }

        public List<Ticket> Tickets { get; set; }
    }
}
