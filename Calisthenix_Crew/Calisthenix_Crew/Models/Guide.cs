using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Calisthenix_Crew.Models
{
    public class Guide
    {

        [Key]
        public int ID { get; set; }

        public string Descricao { get; set; }

        public virtual ICollection<Multimedia> ListaDeMultimedia { get; set; }
        public virtual ICollection<ExerciseGuide> ListaDeExercisesGuide { get; set; }

    }
}