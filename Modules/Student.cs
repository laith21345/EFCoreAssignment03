using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Modules
{
    //DeptId FK
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [Length(1, 15, ErrorMessage = "The FName Length Of The Student must be >=1 & <=15")]
        public string FName { get; set; } = null!;
        public string? LName { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }

        public int DeptId { get; set; }
        public virtual Department Department { get; set; } = null!;

        public virtual ICollection<StudCourse> StudCourse { get; set; } = null!;
    }

}
