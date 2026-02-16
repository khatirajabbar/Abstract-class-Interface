namespace ConsoleApp13;

public abstract class Food
{
    public int Id;
    public string Name;
    private DateTime _releaseDate;
    public double Price;

    public DateTime RelaseDate
    {
        get { return _releaseDate; }
        set
        {
            if (!(value.Date < DateTime.Now.Date))
                _releaseDate = value;
            return;
        }

    }

    public TimeSpan PreparationTime { get; set; }
    private double _calories;

    public double Calories
    {
        get { return _calories; }
        set
        {
            if (!(value < 0))
                _calories = value;
            return;
        }
    }

    public abstract void CalcPrice();

    public Food()
    {
        
    }
    public Food(int id, string name, DateTime releaseDate, TimeSpan preparationTime, double calories)
    {
        Id = id;
        Name = name;
        RelaseDate = releaseDate;
        PreparationTime = preparationTime;
        Calories = calories;
    }
    public override string ToString()
    {
        return $"Name: {Name} Id: {Id} Release Date: {_releaseDate} Preparation Time: {PreparationTime} Calories: {_calories} ";
    }
}

