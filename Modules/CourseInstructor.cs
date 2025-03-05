using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Program.Modules
{
    //CourseId with InstId => PK
    //CourseId / InstId => FK
    public class CourseInstructor
    {
        public int CourseId { get; set; }
        public int InstId { get; set; }

        [MaxLength(20)]
        public string? Evaluation { get; set; }

        public virtual Course Course { get; set; } = null!;
        public virtual Instructor Instructor { get; set; } = null!;
    }

}
