namespace ConsoleApp13;

public interface IFoodService
{
    public DateTime WhenWillBePrapered(TimeSpan timeSpan);
    public int MoreThanNCalories(int nCalories);
}