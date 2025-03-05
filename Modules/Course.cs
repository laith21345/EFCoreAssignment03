using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

    //[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace Program.Modules
{
    // TopId FK
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; } = null!;
        public int Duration { get; set; }
        public string? Description { get; set; }

        public int TopId { get; set; }
        public virtual Topic Topic { get; set; } = null!;

        public virtual ICollection<StudCourse> StudCourse { get; set; } = null!;

        public virtual ICollection<CourseInstructor>? CourseInstructor { get; set; }
    }

}
