namespace ConsoleApp13;
public interface IFoodService
{
    public DateTime WhenWillPrepared(Food food); 
    public int GetCountByCalories(Food[] foods, double n); 
}