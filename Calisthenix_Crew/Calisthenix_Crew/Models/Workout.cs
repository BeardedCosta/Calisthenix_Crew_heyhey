using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Calisthenix_Crew.Models
{
    public class Workout
    {

        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        // public string Fotografia { get; set; }

        public string Descricao { get; set; }


        public virtual ICollection<Suplement> ListaDeSuplements { get; set; }
        public virtual ICollection<Exercise> ListaDeExercises { get; set; }

    }
}