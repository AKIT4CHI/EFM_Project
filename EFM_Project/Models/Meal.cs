using EFM_Project.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFM_Project.Models
{
    public class Meal
    {
        [Key] public int Meal_id { get; set; }
        public string Meal_name { get; set; }
        public string Meal_description { get; set; }
        public string Meal_image { get; set; }
        public MealCategory MealCategory { get; set; }

        //Category
        public int Category_id { get; set; }
        [ForeignKey("Category_id")]
        public Category Category { get; set; }

        
    }
}
