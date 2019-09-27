using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebEval.Models
{
    public class Estudent
    {
        public enum TypeGender
        {
            male,
            famale,

        }
        public enum TypeStatus
        {
            Pass,
            Fail
        }

        [Key]
        public int StudentID { get; set; }
        [Required]
        public TypeGender Gender { get; set; }
        [Required(ErrorMessage = "Plasse Enter Name")]
        public string Nombre { get; set; }
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        [Range(0,100,ErrorMessage ="Grades can only be between 0 and 100")]
        public int Mark { get; set; }
        [Required]
        public TypeStatus Status { get; set; }

    }
}