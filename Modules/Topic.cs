using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Modules
{
    public class Topic
    {
        public int Id { get; set; }

        [Required]
        [Length(1, 15, ErrorMessage = "The Name Length Of The Topic must be >=1 & <=20")]
        public string Name { get; set; } = null!;

        public virtual ICollection<Course>? Courses { get; set; }
    }
}
