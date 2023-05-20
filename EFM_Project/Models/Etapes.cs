using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFM_Project.Models
{
    public class Etapes
    {
        [Key] public int Etape_id { get; set; }
        public string Etape_title { get; set; }
        public string Etape_description { get; set; }
        public int Etape_order { get; set; }

        public List<Quantity> Quantities { get; set; }

        public int Meal_id { get; set; }
        [ForeignKey("Meal_id")]
        public Meal Meal { get; set; }
    }
}
