using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFM_Project.Models
{
    public class Category
    {
        [Key]
        public int Category_id { get; set; }
        [Display(Name = "Category Name")]
        public string Category_name { get; set; }
        [Display(Name = "Category Image")]
        public string Category_image { get; set;}

        //RelationShips
        public List<Meal> Meals { get; set; }

        
    }
}
