using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Entity
{
    public class ParkingLot
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string Place { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string Area { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string Status { get; set; }

        [Required]
        public int Price { get; set; }

        public List<Car> Cars { get; set; }

    }
}
