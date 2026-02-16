namespace ConsoleApp13;

public class FoodService : Food, IFoodService
{
    
    
    
    public DateTime WhenWillBePrapered(TimeSpan timeSpan)
    {
        DateTime now = DateTime.Now + timeSpan;
        return now;
    }

    public int MoreThanNCalories(int nCalories)
    {
        
        
        return 0;
    }

    public override void CalcPrice()
    {
        throw new NotImplementedException();
    }
}