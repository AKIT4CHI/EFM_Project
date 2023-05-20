using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFM_Project.Models
{
    public class Feedback
    {
        [Key] public int Feedback_id { get; set; }
        public string feedback { get; set; }

        public int Meal_id { get; set; }
        [ForeignKey("Meal_id")]
        public Meal Meal { get; set; }
    }
}
