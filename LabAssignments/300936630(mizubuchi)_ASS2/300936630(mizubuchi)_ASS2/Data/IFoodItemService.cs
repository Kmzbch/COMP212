using System.Collections.Generic;

namespace _300936630_mizubuchi__ASS2.Data
{
    public interface IFoodItemService
    {
        IEnumerable<FoodItem> GetAll();
    }
}
