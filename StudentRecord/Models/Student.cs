using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentRecord.Models
{
    public class Student
    {
        [Key]
        [DisplayName("Admission Number")]
        public int StudentId { get; set; }
        [DisplayName("Name")]
        [Required]
        public string ?StudentName { get; set; }
        [DisplayName("Class")]
        [Range(1,12)]
        [Required]
        public int StudentClass { get; set; }
    }
}
