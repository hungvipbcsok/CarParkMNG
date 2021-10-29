using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Entity
{
    public class Trip
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Destination { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Driver { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string CarType { get; set; }

        [Required]
        public int BookedTicketNumber { get; set; }

        [Required]
        public int MaxTicketNumber { get; set; }

        [Required]
        public DateTime DepartureDate { get; set; }

        [Required]
        public DateTime DepartureTime { get; set; }

        public virtual List<BookingOffice> BookingOffices { get; set; }
        public virtual List<Ticket> Tickets { get; set; }

    }
}
