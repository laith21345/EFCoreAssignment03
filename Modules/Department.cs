using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Modules
{
    //InsId FK
    public class Department
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; } = null!;
        
        public int InsId { get; set; }
        public DateTime HiringDate { get; set; }
        public virtual Instructor Manager { get; set; } = null!;

        public virtual ICollection<Student>? Students { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; } = null!;

    }
}
