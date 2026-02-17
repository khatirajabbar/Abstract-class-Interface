namespace ConsoleApp13;
public class FoodService : IFoodService
{
    public DateTime WhenWillPrepared(Food food)
    {
        return food.RelaseDate + food.PreparationTime;
    }

    public int GetCountByCalories(Food[] foods, double n)
    {
        int count = 0;
        foreach (var food in foods)
        {
            if (food.Calories > n) count++;
        }
        return count;
    }

}