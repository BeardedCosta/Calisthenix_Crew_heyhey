using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Calisthenix_Crew.Models
{
    public class Multimedia
    {

        [Key]
        public int ID { get; set; }

        //COLOCAR TIPO (IMG OU VIDEO)

        public string src { get; set; }

        [ForeignKey("Guide")]
        public int GuideFK { get; set; }
        public virtual Guide Guide { get; set; }
    }
}