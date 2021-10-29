using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Entity
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string FullName { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Sex { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Address { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Phone { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string Account { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string Password { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Department { get; set; }
    }
}
