using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Calisthenix_Crew.Models
{
    public class ExerciseGuide
    {

        [Key]
        public int ID { get; set; }

        public int NumeroDeOrdem { get; set; }


        [ForeignKey("Exercises")]
        public int ExercisesFK { get; set; }
        public virtual Exercise Exercises { get; set; }

        [ForeignKey("Guide")]
        public int GuideFK { get; set; }
        public virtual Guide Guide { get; set; }
    }
}