using System.ComponentModel.DataAnnotations;

namespace EFM_Project.Models
{
    public class Quantity
    {
        
        public int Etape_id { get; set; }
        public Etapes Etapes { get; set; }
        
        public int Ingredient_id { get; set; }
        public Ingredient Ingredient { get; set; }

        public int Qte { get; set; }
    }
}
