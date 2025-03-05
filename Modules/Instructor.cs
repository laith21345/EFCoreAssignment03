using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Modules
{
    //DeptID FK
    public class Instructor
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; } = null!;
        public string? Address { get; set; }
        public float? Bonus { get; set; }
        public float Salary { get; set; }
        public float HourRate { get; set; }

        public virtual Department? ManagedDepartment { get; set; }

        public int DeptID { get; set; }
        public virtual Department Department { get; set; } = null!;

        public virtual ICollection<CourseInstructor>? CourseInstructor { get; set; }
    }
}
