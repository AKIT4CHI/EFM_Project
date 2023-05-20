using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFM_Project.Models
{
    public class Ingredient
    {
        [Key]
        public int Ingredient_id { get; set; }
        [Display(Name ="Ingredient Name")]
        public string Ingredient_name { get; set; }
        [Display(Name = "Ingredient Unit")]
        public string Unit { get; set; }
        [Display(Name = "Ingredient Image")]
        public string Ingredient_image { get; set; }

        public List<Quantity> Quantities { get; set; }

    }
}
