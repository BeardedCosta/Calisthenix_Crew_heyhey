using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Calisthenix_Crew.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        //DECIDIR

        // DESTA FORMA, A CADA USER É APENAS ATRIBUIDO UM WORKOUT.
        // E SE O USER ACEDER A OUTRO WORKOUT, O ANTIGO É "APAGADO".

        //public Users()
        //{
        //    ListaDeWorkouts = new HashSet<Workout>();
        //}

        [ForeignKey("Workout")]
        public int WorkoutFK { get; set; }
        public virtual Workout Workout { get; set; }

        //    public virtual ICollection<Workout> ListaDeWorkouts { get; set; }

    }
}