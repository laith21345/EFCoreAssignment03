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
    //StudId with CourseId => PK
    //StudId / CourseId => FK
    public class StudCourse
    {
        public int StudId { get; set; }
        public int CourseId { get; set; }

        [Range(0,100)]
        public float? Grade { get; set; }

        public virtual Student Student { get; set; } = null!;
        public virtual Course Course { get; set; } = null!;
    }
}
