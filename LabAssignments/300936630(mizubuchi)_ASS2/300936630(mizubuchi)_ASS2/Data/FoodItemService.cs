using System.Collections.Generic;

namespace _300936630_mizubuchi__ASS2.Data
{
    public class FoodItemService : IFoodItemService
    {
        public IEnumerable<FoodItem> GetAll()
        {
            // Beverage
            yield return new FoodItem { Id = 1, Name = "Soda", Category = "Beverage", Price=1.95M, };
            yield return new FoodItem { Id = 2, Name = "Tea", Category = "Beverage", Price = 1.50M };
            yield return new FoodItem { Id = 3, Name = "Coffee", Category = "Beverage", Price = 1.25M };
            yield return new FoodItem { Id = 4, Name = "Mineral Water", Category = "Beverage", Price = 2.95M };
            yield return new FoodItem { Id = 5, Name = "Juice", Category = "Beverage", Price = 2.5M };
            yield return new FoodItem { Id = 6, Name = "Milk", Category = "Beverage", Price = 1.5M };

            // Appetizer
            yield return new FoodItem { Id = 7, Name = "Buffalo Wings", Category = "Appetizer", Price = 5.95M };
            yield return new FoodItem { Id = 8, Name = "Buffalo Fingers", Category = "Appetizer", Price = 6.95M };
            yield return new FoodItem { Id = 9, Name = "Potato Skins", Category = "Appetizer", Price = 8.95M };
            yield return new FoodItem { Id = 10, Name = "Nachos", Category = "Appetizer", Price = 8.95M };
            yield return new FoodItem { Id = 11, Name = "Mushroom Caps", Category = "Appetizer", Price = 10.95M };
            yield return new FoodItem { Id = 12, Name = "Shrimp Cocktail", Category = "Appetizer", Price = 12.95M };
            yield return new FoodItem { Id = 13, Name = "Chips and Salsa", Category = "Appetizer", Price = 6.95M };

            // Main Course
            yield return new FoodItem { Id = 14, Name = "Seafood Alfredo", Category = "Main Course", Price = 15.95M };
            yield return new FoodItem { Id = 15, Name = "Chicken Alfredo", Category = "Main Course", Price = 13.95M };
            yield return new FoodItem { Id = 16, Name = "Chicken Picatta", Category = "Main Course", Price = 13.95M };
            yield return new FoodItem { Id = 17, Name = "Turkey Club", Category = "Main Course", Price = 11.95M };
            yield return new FoodItem { Id = 18, Name = "Lobster Pie", Category = "Main Course", Price = 19.95M };
            yield return new FoodItem { Id = 19, Name = "Prime Rib", Category = "Main Course", Price = 20.95M };
            yield return new FoodItem { Id = 20, Name = "Shrimp Scampi", Category = "Main Course", Price = 18.95M };
            yield return new FoodItem { Id = 21, Name = "Turkey Dinner", Category = "Main Course", Price = 13.95M };
            yield return new FoodItem { Id = 22, Name = "Stuffed Chicken", Category = "Main Course", Price = 14.95M };

            // Dessert
            yield return new FoodItem { Id = 23, Name = "Sundae", Category = "Dessert", Price = 3.95M };
            yield return new FoodItem { Id = 24, Name = "Carrot Cake", Category = "Dessert", Price = 5.95M };
            yield return new FoodItem { Id = 25, Name = "Mud Pie", Category = "Dessert", Price = 4.95M };
            yield return new FoodItem { Id = 26, Name = "Apple Crisp", Category = "Dessert", Price = 5.95M };

        }
    }
}
