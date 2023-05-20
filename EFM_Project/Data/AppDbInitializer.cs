using EFM_Project.Data.Enums;
using EFM_Project.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace EFM_Project.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();
                //Category
                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(new List<Category>()
                    {
                    new Category()
                    {
                        Category_name = "Category 1",
                        Category_image = "http://dotnethow.net/images/actors/actor-1.jpeg",


                    },
                    new Category()
                    {
                        Category_name = "Category 2",
                        Category_image = "http://dotnethow.net/images/actors/actor-1.jpeg",


                    },
                    new Category()
                    {
                        Category_name = "Category 3",
                        Category_image = "http://dotnethow.net/images/actors/actor-1.jpeg",


                    },
                    new Category()
                    {
                        Category_name = "Category 4",
                        Category_image = "http://dotnethow.net/images/actors/actor-1.jpeg",


                    },



                        });
                    context.SaveChanges();
                }

                //Meal
                if (!context.Meals.Any())
                {
                    context.Meals.AddRange(new List<Meal>()
                    {
                    new Meal()
                    {
                        Meal_name = "Meal 1",
                        Meal_description = "This is the Bio of the first Meal",
                        Meal_image = "http://dotnethow.net/images/actors/actor-1.jpeg",
                        Category_id = 1,
                        MealCategory = MealCategory.Cake

                    },
                    new Meal()
                    {
                        Meal_name = "Meal 1",
                        Meal_description = "This is the Bio of the first Meal",
                        Meal_image = "http://dotnethow.net/images/actors/actor-1.jpeg",
                        Category_id = 2,
                        MealCategory = MealCategory.Cake

                    },
                    new Meal()
                    {
                        Meal_name = "Meal 1",
                        Meal_description = "This is the Bio of the first Meal",
                        Meal_image = "http://dotnethow.net/images/actors/actor-1.jpeg",
                        Category_id = 3,
                        MealCategory = MealCategory.Cake

                    },
                    new Meal()
                    {
                        Meal_name = "Meal 1",
                        Meal_description = "This is the Bio of the first Meal",
                        Meal_image = "http://dotnethow.net/images/actors/actor-1.jpeg",
                        Category_id = 4,
                        MealCategory = MealCategory.Cake

                    },


                        });
                    context.SaveChanges();
                }

                //Etapes
                if (!context.Etapes.Any())
                {
                    context.Etapes.AddRange(new List<Etapes>()
                    {
                    new Etapes()
                    {
                        Etape_title = "Etape 1",
                        Etape_description = "HH",
                        Etape_order = 1,
                        Meal_id = 1


                    },
                    new Etapes()
                    {
                        Etape_title = "Etape 2",
                        Etape_description = "HH",
                        Etape_order = 2,
                        Meal_id = 2


                    },
                    new Etapes()
                    {
                        Etape_title = "Etape 3",
                        Etape_description = "HH",
                        Etape_order = 3,
                        Meal_id = 3


                    },
                    new Etapes()
                    {
                        Etape_title = "Etape 4",
                        Etape_description = "HH",
                        Etape_order = 4,
                        Meal_id = 4


                    },



                        });
                    context.SaveChanges();

                }
                //Ingredient
                if (!context.Ingredients.Any())
                {
                    context.Ingredients.AddRange(new List<Ingredient>()
                    {
                    new Ingredient()
                    {
                        Ingredient_name = "Ingredient 1",
                        Unit = "Gram",
                        Ingredient_image = "https://www.southernliving.com/thmb/JOV1II4ho49bEI50Drk4RDtDK1Y=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/How_To_Soften_Butter_013-2000-61e8b4e1ad9c431887472483ae714dbb.jpg"


                    },
                    new Ingredient()
                    {
                        Ingredient_name = "Ingredient 2",
                        Unit = "Gram",
                        Ingredient_image = "http://dotnethow.net/images/actors/actor-1.jpeg"


                    },
                    new Ingredient()
                    {
                        Ingredient_name = "Ingredient 3",
                        Unit = "Gram",
                        Ingredient_image = "http://dotnethow.net/images/actors/actor-1.jpeg"


                    },
                    new Ingredient()
                    {
                        Ingredient_name = "Ingredient 4",
                        Unit = "Gram",
                        Ingredient_image = "http://dotnethow.net/images/actors/actor-1.jpeg"


                    },


                    });
                    context.SaveChanges();
                }


                //Quantity ( ingredient & etape)
                if (!context.Quantity.Any())
                {
                    context.Quantity.AddRange(new List<Quantity>()
                    {
                    new Quantity()
                    {
                        Etape_id = 1,
                        Ingredient_id = 1
                        

                    },
                    new Quantity()
                    {
                        Etape_id = 2,
                        Ingredient_id = 2


                    },
                   new Quantity()
                    {
                        Etape_id = 3,
                        Ingredient_id = 3


                    },
                    new Quantity()
                    {
                        Etape_id = 4,
                        Ingredient_id = 4


                    },


                    });
                }

                //Feedback
                if (!context.Feedbacks.Any())
                {
                    context.Feedbacks.AddRange(new List<Feedback>()
                    {
                    new Feedback()
                    {
                        feedback = "Good Meal",
                        Meal_id = 1
                        

                    },
                    new Feedback()
                    {
                        feedback = "Good Meal",
                        Meal_id = 2


                    },
                    new Feedback()
                    {
                        feedback = "Good Meal",
                        Meal_id = 3


                    },
                    new Feedback()
                    {
                        feedback = "Good Meal",
                        Meal_id = 4


                    },


                    });
                }
            }
        }
    }
}
