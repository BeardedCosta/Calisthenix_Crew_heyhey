using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Calisthenix_Crew.Models
{
    public class Suplement
    {

        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Fotografia { get; set; }

        public int Calorias { get; set; }

        public string Tipo { get; set; }

        public string Descricao { get; set; }


        public virtual ICollection<Workout> ListaDeWorkouts { get; set; }

    }
}