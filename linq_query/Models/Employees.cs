using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace linq_query.Models
{
    public class Employees
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [Column("Name", TypeName = "varchar(50)")]
        public string Name { get; set; }
        [Required]
        [Column("Salary", TypeName = "int")]
        public int Salary { get; set; }
    }
}